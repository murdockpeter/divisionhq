// ==================================================================================
// Supply Drop System
//
// Enables click-to-target supply drops that resupply friendly units in a radius
// around the selected hex. Applies the enabler cost/cooldown only after the
// player confirms a valid target.
// ==================================================================================

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DivisionEnablersMod
{
    public static class SupplyDropSystem
    {
        public static bool IsTargetingActive { get; private set; } = false;

        private static Player _requestingPlayer = null;
        private static int _radius = 1;
        private static float _supplyBonus = 100f;

        public static void ActivateTargeting(Player player, int radius = 1, float supplyBonus = 75f)
        {
            _requestingPlayer = player;
            _radius = Mathf.Clamp(radius, 0, 3);
            _supplyBonus = Mathf.Clamp(supplyBonus, 0f, 100f);
            IsTargetingActive = true;

            UIManager.ShowMessage($"Supply Drop: Select a hex to resupply (R{_radius})");
            Debug.Log($"[SupplyDrop] Targeting activated for {player.Country} - radius={_radius}, bonus={_supplyBonus}");
        }

        public static void CancelTargeting()
        {
            IsTargetingActive = false;
            _requestingPlayer = null;
            UIManager.ShowMessage("Supply Drop cancelled");
            Debug.Log("[SupplyDrop] Targeting cancelled");
        }

        public static void ExecuteSupplyDrop(Tile targetTile, TileGO targetTileGO)
        {
            if (!IsTargetingActive || _requestingPlayer == null || targetTile == null)
            {
                Debug.LogWarning("[SupplyDrop] Cannot execute - invalid state");
                return;
            }

            var playerData = DivisionEnablers.GetPlayerData(_requestingPlayer);
            var enabler = playerData?.GetEnabler(DivisionEnablers.EnablerType.SupplyDrop);
            if (enabler == null)
            {
                UIManager.ShowMessage("Supply Drop unavailable");
                CancelTargeting();
                return;
            }

            if (!enabler.CanRequest(_requestingPlayer))
            {
                UIManager.ShowMessage("Cannot request Supply Drop now");
                CancelTargeting();
                return;
            }

            // Deduct cost / apply cooldown
            enabler.Request(_requestingPlayer);

            int unitsResupplied = 0;
            foreach (var tileGO in GetTilesInRadius(targetTileGO, _radius))
            {
                unitsResupplied += ResupplyUnit(tileGO?.groundUnitGO);
                unitsResupplied += ResupplyUnit(tileGO?.airUnitGO);
            }

            if (unitsResupplied > 0)
            {
                UIManager.ShowMessage($"Supply Drop delivered! Resupplied {unitsResupplied} unit(s).");
            }
            else
            {
                UIManager.ShowMessage("Supply Drop delivered, but no friendly units were in range.");
            }

            Debug.Log($"[SupplyDrop] Drop completed at ({targetTile.PosX},{targetTile.PosY}), resupplied {unitsResupplied} units");

            IsTargetingActive = false;
            _requestingPlayer = null;
        }

        private static int ResupplyUnit(UnitGO unitGO)
        {
            if (unitGO == null || unitGO.unit == null) return 0;

            Unit unit = unitGO.unit;
            if (unit.OwnerPlayer != _requestingPlayer)
                return 0;

            float currentSupply = unit.SupplyPercentage;
            float newSupply = Mathf.Clamp(currentSupply + _supplyBonus, 0f, 100f);
            if (newSupply <= currentSupply + 0.01f)
                return 0;

            unit.SupplyPercentage = newSupply;

            try
            {
                unitGO.UpdateCounter();
            }
            catch (Exception ex)
            {
                Debug.LogError($"[SupplyDrop] Failed to update counter: {ex.Message}");
            }

            return 1;
        }

        private static List<TileGO> GetTilesInRadius(TileGO centerTileGO, int radius)
        {
            var results = new List<TileGO>();
            if (centerTileGO == null || centerTileGO.tile == null) return results;

            var visited = new HashSet<Tile>();
            var queue = new Queue<(Tile tile, int dist)>();
            queue.Enqueue((centerTileGO.tile, 0));
            visited.Add(centerTileGO.tile);

            while (queue.Count > 0)
            {
                var (tile, dist) = queue.Dequeue();
                TileGO tileGO = dist == 0 ? centerTileGO : FindTileGO(tile);
                if (tileGO != null)
                    results.Add(tileGO);

                if (dist >= radius) continue;

                if (tile?.neighbours == null) continue;

                foreach (var neighbour in tile.neighbours)
                {
                    if (neighbour == null) continue;
                    if (visited.Add(neighbour))
                        queue.Enqueue((neighbour, dist + 1));
                }
            }

            return results;
        }

        private static TileGO FindTileGO(Tile tile)
        {
            if (tile == null) return null;

            var allTiles = UnityEngine.Object.FindObjectsOfType<TileGO>();
            foreach (var tileGO in allTiles)
            {
                if (tileGO != null && tileGO.tile == tile)
                    return tileGO;
            }
            return null;
        }
    }

    // ==================================================================================
    // MonoBehaviour to handle Supply Drop targeting clicks
    // ==================================================================================
    public class SupplyDropClickHandler : MonoBehaviour
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
                    Debug.Log("[SupplyDrop] Input system initialized");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[SupplyDrop] Failed to initialize Input: {ex.Message}");
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
            if (!SupplyDropSystem.IsTargetingActive)
                return;

            if (GetKeyDown(KeyCode.Escape))
            {
                SupplyDropSystem.CancelTargeting();
                return;
            }

            if (GetMouseButtonDown(0))
            {
                var tileGO = FindTileGOAtMouse();
                if (tileGO != null && tileGO.tile != null)
                {
                    Debug.Log($"[SupplyDrop] Tile selected: ({tileGO.tile.PosX},{tileGO.tile.PosY})");
                    SupplyDropSystem.ExecuteSupplyDrop(tileGO.tile, tileGO);
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

