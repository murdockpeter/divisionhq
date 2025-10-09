// ==================================================================================
// Air Recon System
//
// Provides click-to-target air reconnaissance that reveals fog of war
// around a selected hex for a limited duration. Persists recon zones in
// mod data and reapplies reveal at turn changes.
// ==================================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DivisionEnablersMod
{
    public static class AirReconSystem
    {
        public static bool IsTargetingActive { get; private set; } = false;

        private static Player _requestingPlayer = null;
        private static int _durationTurns = 0;
        private static int _radius = 2;

        public static void ActivateTargeting(Player player, int durationTurns, int radius = 2)
        {
            _requestingPlayer = player;
            _durationTurns = Mathf.Max(1, durationTurns);
            _radius = Mathf.Clamp(radius, 1, 3);
            IsTargetingActive = true;

            UIManager.ShowMessage($"Air Recon: Select a hex to reveal (R{_radius})");
            Debug.Log($"[AirRecon] Targeting activated for {player.Country} - duration={_durationTurns}, radius={_radius}");
        }

        public static void CancelTargeting()
        {
            IsTargetingActive = false;
            _requestingPlayer = null;
            _durationTurns = 0;
            UIManager.ShowMessage("Air Recon cancelled");
            Debug.Log("[AirRecon] Targeting cancelled");
        }

        public static void ExecuteRecon(Tile targetTile, TileGO targetTileGO)
        {
            if (!IsTargetingActive || _requestingPlayer == null || targetTile == null)
            {
                Debug.LogWarning("[AirRecon] Cannot execute recon - invalid state");
                return;
            }

            // Resolve enabler and validate affordability before committing
            var playerData = DivisionEnablers.GetPlayerData(_requestingPlayer);
            var enabler = playerData?.GetEnabler(DivisionEnablers.EnablerType.AirReconnaissance);
            if (enabler == null)
            {
                UIManager.ShowMessage("Air Recon unavailable");
                CancelTargeting();
                return;
            }

            if (!enabler.CanRequest(_requestingPlayer))
            {
                UIManager.ShowMessage("Cannot request Air Recon now");
                CancelTargeting();
                return;
            }

            // Charge cost + start cooldown
            enabler.Request(_requestingPlayer);

            // Add a recon zone to persist for duration
            DivisionEnablers.AddAirReconZoneForPlayer(_requestingPlayer, targetTile.PosX, targetTile.PosY, _durationTurns, _radius);

            // Apply immediate reveal
            RevealAroundTileGO(targetTileGO, _radius);

            UIManager.ShowMessage($"Air Recon active for {_durationTurns} turns (R{_radius})");
            Debug.Log($"[AirRecon] Recon placed at ({targetTile.PosX},{targetTile.PosY}) R{_radius} for {_durationTurns} turns");

            // Reset state
            IsTargetingActive = false;
            _requestingPlayer = null;
            _durationTurns = 0;
        }

        // Reapply reveals for all active recon zones of a player
        public static void ReapplyZonesForPlayer(Player player)
        {
            if (player == null) return;

            var modData = DivisionEnablers.GetModData();
            var pdata = modData?.GetPlayerData(player);
            if (pdata == null || pdata.activeReconZones == null) return;

            foreach (var zone in pdata.activeReconZones)
            {
                var tileGO = FindTileGOByCoords(zone.x, zone.y);
                if (tileGO != null)
                {
                    RevealAroundTileGO(tileGO, zone.radius);
                }
            }
        }

        // Helper: Reveal fog around a TileGO within hex radius (1 = neighbors)
        private static void RevealAroundTileGO(TileGO centerTileGO, int radius)
        {
            if (centerTileGO == null || centerTileGO.tile == null) return;

            // Always reveal center
            SafeRemoveFog(centerTileGO);

            if (radius <= 0) return;

            // Ring 1: immediate neighbors from tile.neighbours
            var ring1 = GetAdjacentTileGOs(centerTileGO.tile);
            foreach (var tile in ring1) SafeRemoveFog(tile);

            if (radius <= 1) return;

            // Ring 2: neighbors of neighbors (simple superset; duplicates ok)
            var ring2 = new List<TileGO>();
            foreach (var t1 in ring1)
            {
                if (t1?.tile == null) continue;
                ring2.AddRange(GetAdjacentTileGOs(t1.tile));
            }
            foreach (var tile in ring2) SafeRemoveFog(tile);
        }

        private static void SafeRemoveFog(TileGO tileGO)
        {
            try { tileGO.RemoveFogOfWar(); }
            catch (Exception ex) { Debug.LogError($"[AirRecon] RemoveFogOfWar error: {ex.Message}"); }
        }

        private static List<TileGO> GetAdjacentTileGOs(Tile centerTile)
        {
            var adjacent = new List<TileGO>();
            if (centerTile == null || centerTile.neighbours == null) return adjacent;
            foreach (var neighbour in centerTile.neighbours)
            {
                if (neighbour == null) continue;
                var tgo = FindTileGO(neighbour);
                if (tgo != null) adjacent.Add(tgo);
            }
            return adjacent;
        }

        private static TileGO FindTileGO(Tile tile)
        {
            var all = UnityEngine.Object.FindObjectsOfType<TileGO>();
            foreach (var t in all)
            {
                if (t != null && t.tile == tile) return t;
            }
            return null;
        }

        private static TileGO FindTileGOByCoords(int x, int y)
        {
            var all = UnityEngine.Object.FindObjectsOfType<TileGO>();
            foreach (var t in all)
            {
                if (t?.tile != null && t.tile.PosX == x && t.tile.PosY == y)
                    return t;
            }
            return null;
        }
    }

    // ==================================================================================
    // MonoBehaviour to handle Air Recon targeting clicks
    // ==================================================================================
    public class AirReconClickHandler : MonoBehaviour
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
                    Debug.Log("[AirRecon] Input system initialized");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[AirRecon] Failed to initialize Input: {ex.Message}");
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
            if (!AirReconSystem.IsTargetingActive)
                return;

            // ESC to cancel
            if (GetKeyDown(KeyCode.Escape))
            {
                AirReconSystem.CancelTargeting();
                return;
            }

            if (GetMouseButtonDown(0))
            {
                var tgo = FindTileGOAtMouse();
                if (tgo != null && tgo.tile != null)
                {
                    Debug.Log($"[AirRecon] Tile selected: ({tgo.tile.PosX},{tgo.tile.PosY})");
                    AirReconSystem.ExecuteRecon(tgo.tile, tgo);
                }
            }
        }

        TileGO FindTileGOAtMouse()
        {
            var allTileGOs = FindObjectsOfType<TileGO>();
            Vector3 mousePos = GetMousePosition();

            TileGO best = null;
            float bestDist = float.MaxValue;
            foreach (var tileGO in allTileGOs)
            {
                if (tileGO == null || tileGO.transform == null) continue;
                Vector3 screenPos = Camera.main.WorldToScreenPoint(tileGO.transform.position);
                float dist = Vector2.Distance(new Vector2(screenPos.x, screenPos.y), new Vector2(mousePos.x, mousePos.y));
                if (dist < bestDist && dist < 50f)
                {
                    bestDist = dist;
                    best = tileGO;
                }
            }
            return best;
        }
    }
}

