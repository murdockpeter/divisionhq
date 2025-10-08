// ==================================================================================
// Artillery System - Simplified Version
//
// Implements configurable artillery effects with hex targeting and splash damage
// Three modes: Area Damage, Precision Strike, and Suppression Barrage
//
// Uses TileGO directly to avoid API compatibility issues
// ==================================================================================

using System;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;

namespace DivisionEnablersMod
{
    public static class ArtillerySystem
    {
        /// <summary>
        /// Types of artillery effects available
        /// </summary>
        public enum ArtilleryMode
        {
            AreaDamage,         // High damage to target hex, medium damage to adjacent
            PrecisionStrike,    // Very high damage to single hex only
            SuppressionBarrage  // Low damage but affects wider area (2 hex radius)
        }

        /// <summary>
        /// Current artillery configuration
        /// </summary>
        public static ArtilleryMode CurrentMode { get; set; } = ArtilleryMode.AreaDamage;

        /// <summary>
        /// Whether artillery targeting mode is currently active
        /// </summary>
        public static bool IsTargetingActive { get; private set; } = false;

        private static Player _requestingPlayer = null;

        /// <summary>
        /// Activate artillery targeting mode
        /// </summary>
        public static void ActivateTargeting(Player player)
        {
            IsTargetingActive = true;
            _requestingPlayer = player;
            Debug.Log($"[Artillery] Targeting activated for {player.Country} - Mode: {CurrentMode}");
            UIManager.ShowMessage($"Artillery targeting active - Click a hex to strike (Mode: {GetModeName(CurrentMode)})");
        }

        /// <summary>
        /// Cancel artillery targeting
        /// </summary>
        public static void CancelTargeting()
        {
            IsTargetingActive = false;
            _requestingPlayer = null;
            Debug.Log("[Artillery] Targeting cancelled");
            UIManager.ShowMessage("Artillery strike cancelled");
        }

        /// <summary>
        /// Execute artillery strike on target hex
        /// </summary>
        public static void ExecuteStrike(Tile targetTile, TileGO targetTileGO)
        {
            if (!IsTargetingActive || _requestingPlayer == null || targetTile == null)
            {
                Debug.LogWarning("[Artillery] Cannot execute strike - invalid state");
                return;
            }

            Debug.Log($"[Artillery] Executing {CurrentMode} strike on tile at ({targetTile.PosX}, {targetTile.PosY})");

            // Deactivate targeting IMMEDIATELY to prevent multiple clicks
            // But keep _requestingPlayer set so DamageUnitsOnTile can check it
            IsTargetingActive = false;
            Player strikePlayer = _requestingPlayer;

            switch (CurrentMode)
            {
                case ArtilleryMode.AreaDamage:
                    ExecuteAreaDamage(targetTile, targetTileGO);
                    break;
                case ArtilleryMode.PrecisionStrike:
                    ExecutePrecisionStrike(targetTile, targetTileGO);
                    break;
                case ArtilleryMode.SuppressionBarrage:
                    ExecuteSuppressionBarrage(targetTile, targetTileGO);
                    break;
            }

            // Clear requesting player after strike is complete
            _requestingPlayer = null;

            UIManager.ShowMessage($"Artillery strike complete! Mode: {GetModeName(CurrentMode)}");
        }

        /// <summary>
        /// Area Damage: High damage to target, medium to adjacent
        /// </summary>
        private static void ExecuteAreaDamage(Tile targetTile, TileGO targetTileGO)
        {
            const int PRIMARY_DAMAGE = 30;
            const int SPLASH_DAMAGE = 15;

            // Damage target hex
            DamageUnitsOnTile(targetTileGO, PRIMARY_DAMAGE, "direct hit");

            // Damage adjacent hexes
            var adjacentTiles = GetAdjacentTileGOs(targetTile);
            foreach (var tileGO in adjacentTiles)
            {
                DamageUnitsOnTile(tileGO, SPLASH_DAMAGE, "splash damage");
            }

            Debug.Log($"[Artillery] Area damage complete: {PRIMARY_DAMAGE} to target, {SPLASH_DAMAGE} to {adjacentTiles.Count} adjacent tiles");
        }

        /// <summary>
        /// Precision Strike: Very high damage to single hex only
        /// </summary>
        private static void ExecutePrecisionStrike(Tile targetTile, TileGO targetTileGO)
        {
            const int PRECISION_DAMAGE = 50;

            DamageUnitsOnTile(targetTileGO, PRECISION_DAMAGE, "precision strike");

            Debug.Log($"[Artillery] Precision strike complete: {PRECISION_DAMAGE} damage to target");
        }

        /// <summary>
        /// Suppression Barrage: Lower damage but wider area (2 hex radius)
        /// </summary>
        private static void ExecuteSuppressionBarrage(Tile targetTile, TileGO targetTileGO)
        {
            const int CENTER_DAMAGE = 20;
            const int RADIUS_1_DAMAGE = 12;
            const int RADIUS_2_DAMAGE = 6;

            // Center hex
            DamageUnitsOnTile(targetTileGO, CENTER_DAMAGE, "barrage center");

            // First ring (adjacent)
            var ring1 = GetAdjacentTileGOs(targetTile);
            foreach (var tileGO in ring1)
            {
                DamageUnitsOnTile(tileGO, RADIUS_1_DAMAGE, "barrage radius 1");
            }

            // Second ring - for simplicity, skip this for now
            // Can be added later with proper hex distance calculations

            Debug.Log($"[Artillery] Suppression barrage complete: affected {1 + ring1.Count} tiles");
        }

        /// <summary>
        /// Apply damage to all units on a tile
        /// </summary>
        private static void DamageUnitsOnTile(TileGO tileGO, int damage, string damageType)
        {
            if (tileGO == null) return;

            var tile = tileGO.tile;
            if (tile == null) return;

            int unitsHit = 0;

            // Check ground unit
            if (tileGO.groundUnitGO != null)
            {
                var unit = tileGO.groundUnitGO.unit;
                if (unit != null && unit.OwnerPlayer != _requestingPlayer)
                {
                    ApplyDamageToUnit(unit, tileGO.groundUnitGO, damage, damageType);
                    unitsHit++;
                }
            }

            // Check air unit
            if (tileGO.airUnitGO != null)
            {
                var unit = tileGO.airUnitGO.unit;
                if (unit != null && unit.OwnerPlayer != _requestingPlayer)
                {
                    ApplyDamageToUnit(unit, tileGO.airUnitGO, damage, damageType);
                    unitsHit++;
                }
            }

            if (unitsHit == 0)
            {
                Debug.Log($"[Artillery] No enemy units on tile ({tile.PosX}, {tile.PosY}) - {damageType}");
            }
        }

        /// <summary>
        /// Apply damage to a single unit
        /// </summary>
        private static void ApplyDamageToUnit(Unit unit, UnitGO unitGO, int damage, string damageType)
        {
            int currentHP = unit.CurrHP;
            int newHP = Mathf.Max(0, currentHP - damage);
            unit.CurrHP = newHP;

            Debug.Log($"[Artillery] {damageType}: {unit.Name} took {damage} damage ({currentHP} -> {newHP})");

            // Update the visual counter to reflect new HP
            if (unitGO != null)
            {
                unitGO.UpdateCounter();
                Debug.Log($"[Artillery] Updated counter for {unit.Name}");

                // Display damage animation and effects
                // Pass null for attacking unit since this is artillery (no attacking UnitGO)
                try
                {
                    unitGO.DisplayDamage(null, unitGO);
                    Debug.Log($"[Artillery] Called DisplayDamage for {unit.Name}");
                }
                catch (System.Exception ex)
                {
                    Debug.LogError($"[Artillery] Error calling DisplayDamage: {ex.Message}");
                }

                // Play attack sound effect
                PlayArtillerySound(unit);
            }
            else
            {
                Debug.LogWarning($"[Artillery] unitGO is null for {unit.Name}");
            }

            if (newHP <= 0)
            {
                Debug.Log($"[Artillery] Unit destroyed: {unit.Name}");
            }
        }

        /// <summary>
        /// Play artillery attack sound effect
        /// </summary>
        private static void PlayArtillerySound(Unit unit)
        {
            try
            {
                if (SoundManager.instance == null)
                {
                    Debug.LogWarning("[Artillery] SoundManager.instance is null");
                    return;
                }

                // Try to find artillery/explosion sounds from actual artillery units in the game
                string[] artillerySounds = {
                    "Heavy artillery",      // Common name
                    "Light artillery",
                    "Medium artillery",
                    "Artillery",
                    "Howitzer",
                    "Gun",
                    "Mortar",
                    "Nebelwerfer",         // German rocket artillery
                    "Katyusha",            // Soviet rocket artillery
                    "Field gun",
                    "Anti-tank gun",
                    "105mm howitzer",
                    "15 cm schwere Feldhaubitze 18",  // German heavy field howitzer
                    "17 cm Kanone 18"      // German heavy gun
                };

                foreach (var soundName in artillerySounds)
                {
                    var soundClip = SoundManager.GetAttackSound(soundName);
                    if (soundClip != null)
                    {
                        SoundManager.instance.unit_Source.PlayOneShot(soundClip);
                        Debug.Log($"[Artillery] Played artillery sound: {soundName}");
                        return;
                    }
                }

                Debug.Log($"[Artillery] No artillery sound found, falling back to target unit sound");

                // Fallback: use the defending unit's attack sound (what we were doing before)
                var fallbackClip = SoundManager.GetAttackSound(unit.Name);
                if (fallbackClip != null)
                {
                    SoundManager.instance.unit_Source.PlayOneShot(fallbackClip);
                    Debug.Log($"[Artillery] Played fallback sound for {unit.Name}");
                }
                else
                {
                    Debug.Log($"[Artillery] No suitable sound found for {unit.Name}");
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogWarning($"[Artillery] Error playing sound: {ex.Message}\n{ex.StackTrace}");
            }
        }

        /// <summary>
        /// Get all TileGOs adjacent to the target tile
        /// </summary>
        private static List<TileGO> GetAdjacentTileGOs(Tile centerTile)
        {
            var adjacentTileGOs = new List<TileGO>();

            if (centerTile == null || centerTile.neighbours == null)
                return adjacentTileGOs;

            // Tile has a neighbours list - use it!
            foreach (var neighbourTile in centerTile.neighbours)
            {
                if (neighbourTile != null)
                {
                    // Try to find the TileGO for this tile
                    var tileGO = FindTileGO(neighbourTile);
                    if (tileGO != null)
                    {
                        adjacentTileGOs.Add(tileGO);
                    }
                }
            }

            return adjacentTileGOs;
        }

        /// <summary>
        /// Find the TileGO corresponding to a Tile
        /// </summary>
        private static TileGO FindTileGO(Tile tile)
        {
            // Search all TileGOs in the scene
            var allTileGOs = UnityEngine.Object.FindObjectsOfType<TileGO>();
            foreach (var tileGO in allTileGOs)
            {
                if (tileGO.tile == tile)
                {
                    return tileGO;
                }
            }
            return null;
        }

        /// <summary>
        /// Get configuration info for a specific mode
        /// </summary>
        public static string GetModeDescription(ArtilleryMode mode)
        {
            switch (mode)
            {
                case ArtilleryMode.AreaDamage:
                    return "30 DMG to target hex, 15 DMG to adjacent hexes";
                case ArtilleryMode.PrecisionStrike:
                    return "50 DMG to single target hex only";
                case ArtilleryMode.SuppressionBarrage:
                    return "20/12 DMG in 1-hex radius (wider area)";
                default:
                    return "Unknown mode";
            }
        }

        public static string GetModeName(ArtilleryMode mode)
        {
            switch (mode)
            {
                case ArtilleryMode.AreaDamage:
                    return "Area Damage";
                case ArtilleryMode.PrecisionStrike:
                    return "Precision Strike";
                case ArtilleryMode.SuppressionBarrage:
                    return "Suppression Barrage";
                default:
                    return "Unknown";
            }
        }
    }

    // ==================================================================================
    // Artillery Click Handler Component
    // ==================================================================================

    /// <summary>
    /// MonoBehaviour component to handle artillery targeting clicks
    /// </summary>
    public class ArtilleryClickHandler : MonoBehaviour
    {
        private static System.Reflection.MethodInfo _getMouseButtonDown;
        private static System.Reflection.MethodInfo _getKeyDown;
        private static System.Reflection.PropertyInfo _mousePosition;
        private static bool _initialized = false;

        static void Initialize()
        {
            if (_initialized) return;

            try
            {
                var inputType = System.Type.GetType("UnityEngine.Input, UnityEngine.InputLegacyModule")
                    ?? System.Type.GetType("UnityEngine.Input, UnityEngine")
                    ?? System.Type.GetType("UnityEngine.Input, UnityEngine.CoreModule");

                if (inputType != null)
                {
                    _getMouseButtonDown = inputType.GetMethod("GetMouseButtonDown", new System.Type[] { typeof(int) });
                    _getKeyDown = inputType.GetMethod("GetKeyDown", new System.Type[] { typeof(KeyCode) });
                    _mousePosition = inputType.GetProperty("mousePosition");
                    Debug.Log("[Artillery] Input system initialized");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[Artillery] Failed to initialize Input: {ex.Message}");
            }

            _initialized = true;
        }

        static bool GetMouseButtonDown(int button)
        {
            Initialize();
            if (_getMouseButtonDown == null) return false;
            try { return (bool)_getMouseButtonDown.Invoke(null, new object[] { button }); }
            catch { return false; }
        }

        static bool GetKeyDown(KeyCode key)
        {
            Initialize();
            if (_getKeyDown == null) return false;
            try { return (bool)_getKeyDown.Invoke(null, new object[] { key }); }
            catch { return false; }
        }

        static Vector3 GetMousePosition()
        {
            Initialize();
            if (_mousePosition == null) return Vector3.zero;
            try { return (Vector3)_mousePosition.GetValue(null); }
            catch { return Vector3.zero; }
        }

        void Update()
        {
            if (!ArtillerySystem.IsTargetingActive)
                return;

            // ESC to cancel
            if (GetKeyDown(KeyCode.Escape))
            {
                ArtillerySystem.CancelTargeting();
                return;
            }

            // Check for mouse click
            if (GetMouseButtonDown(0))
            {
                // Try to find TileGO under mouse using Unity's Physics system
                // Simplified approach: find closest TileGO to camera center
                TileGO closestTileGO = FindTileGOAtMouse();
                if (closestTileGO != null && closestTileGO.tile != null)
                {
                    Debug.Log($"[Artillery] Tile clicked: ({closestTileGO.tile.PosX}, {closestTileGO.tile.PosY})");
                    ArtillerySystem.ExecuteStrike(closestTileGO.tile, closestTileGO);
                }
            }
        }

        TileGO FindTileGOAtMouse()
        {
            // Simple approach: Find all TileGOs and check which one is under mouse
            // This is a fallback since we can't use Physics.Raycast directly
            var allTileGOs = FindObjectsOfType<TileGO>();
            Vector3 mousePos = GetMousePosition();

            TileGO closestTileGO = null;
            float closestDist = float.MaxValue;

            foreach (var tileGO in allTileGOs)
            {
                if (tileGO == null || tileGO.transform == null) continue;

                Vector3 screenPos = Camera.main.WorldToScreenPoint(tileGO.transform.position);
                float dist = Vector2.Distance(new Vector2(screenPos.x, screenPos.y), new Vector2(mousePos.x, mousePos.y));

                if (dist < closestDist && dist < 50f) // Within 50 pixels
                {
                    closestDist = dist;
                    closestTileGO = tileGO;
                }
            }

            return closestTileGO;
        }
    }
}