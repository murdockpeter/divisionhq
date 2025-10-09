// ==================================================================================
// Division Enablers Mod
//
// Tracks special assets that can be requested from Division HQ during gameplay.
// These enablers represent support assets beyond standard unit capabilities.
//
// Key Features:
// - Custom data storage integrated with save system
// - Per-player tracking of available and active enablers
// - Request system with cooldowns/limitations
// - Persistent across save/load
//
// ==================================================================================

using System;
using HarmonyLib;
using UnityEngine;
using System.Collections.Generic;

namespace DivisionEnablersMod
{
    public class DivisionEnablers
    {
        // Unique key for mod data storage
        const string MOD_DATA_KEY = "robbins.divisionenablers.data";

        /// <summary>
        /// Types of enablers that can be requested from Division HQ
        /// </summary>
        public enum EnablerType
        {
            ArtillerySupport,       // Heavy artillery barrage support
            AirReconnaissance,      // Reveal fog of war in area
            EngineerSupport,        // Improve movement/fortification
            SupplyDrop,             // Emergency supply delivery
            Reinforcements,         // Additional units
            TacticalAirStrike,      // Targeted air attack
            MedicalEvacuation,      // Heal units faster
            SignalsIntelligence     // Reveal enemy positions
        }

        /// <summary>
        /// Represents a single enabler asset
        /// </summary>
        [Serializable]
        public class Enabler
        {
            public EnablerType type;
            public string name;
            public string description;
            public int cooldownTurns;           // How many turns until can request again
            public int currentCooldown;         // Current cooldown counter
            public bool isActive;               // Is currently deployed/active
            public int activeDuration;          // How long effect lasts (0 = instant)
            public int remainingDuration;       // Turns remaining for active effect
            public int costMoney;               // Resource cost to request
            public int maxUses;                 // Max uses per game (-1 = unlimited)
            public int remainingUses;           // Uses remaining this game

            public Enabler(EnablerType type, string name, string description,
                          int cooldown = 5, int cost = 100, int maxUses = -1, int duration = 0)
            {
                this.type = type;
                this.name = name;
                this.description = description;
                this.cooldownTurns = cooldown;
                this.currentCooldown = 0;
                this.costMoney = cost;
                this.maxUses = maxUses;
                this.remainingUses = maxUses;
                this.activeDuration = duration;
                this.remainingDuration = 0;
                this.isActive = false;
            }

            public bool CanRequest(Player player)
            {
                if (currentCooldown > 0) return false;
                if (remainingUses == 0) return false;
                if (!PlayerHelper.HasMoney(player, costMoney)) return false;
                if (isActive) return false;
                return true;
            }

            public void Request(Player player)
            {
                if (!CanRequest(player)) return;

                player.AddMoney(-costMoney, false);
                currentCooldown = cooldownTurns;

                if (remainingUses > 0)
                    remainingUses--;

                if (activeDuration > 0)
                {
                    isActive = true;
                    remainingDuration = activeDuration;
                }

                Debug.Log($"[DivisionEnablers] {player.Country} requested {name}");
            }

            public void OnTurnEnd()
            {
                if (currentCooldown > 0)
                    currentCooldown--;

                if (isActive && remainingDuration > 0)
                {
                    remainingDuration--;
                    if (remainingDuration <= 0)
                        isActive = false;
                }
            }
        }

        /// <summary>
        /// Player-specific enabler data
        /// </summary>
        [Serializable]
        public class PlayerEnablerData
        {
            public string playerName;
            public List<Enabler> enablers = new List<Enabler>();
            public List<AirReconZone> activeReconZones = new List<AirReconZone>();

            public PlayerEnablerData(string playerName)
            {
                this.playerName = playerName;
                InitializeDefaultEnablers();
            }

            void InitializeDefaultEnablers()
            {
                enablers.Add(new Enabler(
                    EnablerType.ArtillerySupport,
                    "Artillery Support",
                    "Request heavy artillery barrage from Division HQ",
                    cooldown: 5,
                    cost: 200,
                    maxUses: 3,
                    duration: 0
                ));

                enablers.Add(new Enabler(
                    EnablerType.AirReconnaissance,
                    "Air Reconnaissance",
                    "Aerial reconnaissance reveals enemy positions",
                    cooldown: 3,
                    cost: 150,
                    maxUses: 5,
                    duration: 2
                ));

                enablers.Add(new Enabler(
                    EnablerType.SupplyDrop,
                    "Supply Drop",
                    "Emergency supply delivery to units in the field",
                    cooldown: 4,
                    cost: 100,
                    maxUses: -1,
                    duration: 0
                ));

                enablers.Add(new Enabler(
                    EnablerType.Reinforcements,
                    "Reinforcements",
                    "Request additional units from Division reserve",
                    cooldown: 8,
                    cost: 500,
                    maxUses: 2,
                    duration: 0
                ));
            }

            public Enabler GetEnabler(EnablerType type)
            {
                return enablers.Find(e => e.type == type);
            }

            public void OnTurnEnd()
            {
                foreach (var enabler in enablers)
                    enabler.OnTurnEnd();

                // Update recon zones and remove expired
                if (activeReconZones != null && activeReconZones.Count > 0)
                {
                    for (int i = activeReconZones.Count - 1; i >= 0; i--)
                    {
                        activeReconZones[i].remainingTurns--;
                        if (activeReconZones[i].remainingTurns <= 0)
                            activeReconZones.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Main mod data stored in save file
        /// </summary>
        [Serializable]
        public class ModData
        {
            public Dictionary<string, PlayerEnablerData> playerData = new Dictionary<string, PlayerEnablerData>();

            public void InitializeData(GameData gameData)
            {
                foreach (Player player in gameData.listOfPlayers)
                {
                    if (!playerData.ContainsKey(player.Name))
                    {
                        playerData[player.Name] = new PlayerEnablerData(player.Name);
                        Debug.Log($"[DivisionEnablers] Initialized data for {player.Country}");
                    }
                }
            }

            public void CheckValidData(GameData gameData)
            {
                foreach (Player player in gameData.listOfPlayers)
                {
                    if (!playerData.ContainsKey(player.Name))
                    {
                        playerData[player.Name] = new PlayerEnablerData(player.Name);
                        Debug.LogWarning($"[DivisionEnablers] Added missing data for {player.Country}");
                    }
                }
            }

            public PlayerEnablerData GetPlayerData(Player player)
            {
                if (player == null) return null;

                if (playerData.TryGetValue(player.Name, out var data))
                    return data;

                Debug.LogWarning($"[DivisionEnablers] No data found for {player.Name}");
                return null;
            }

            public void OnTurnEnd()
            {
                foreach (var kvp in playerData)
                    kvp.Value.OnTurnEnd();
            }
        }

        // ==================================================================================
        // Harmony Patches
        // ==================================================================================

        [HarmonyPatch(typeof(GameData))]
        class Patch_GameData
        {
            [HarmonyPrefix]
            [HarmonyPatch(nameof(GameData.SetData))]
            static bool Patch_SetData(GameData p_gameData)
            {
                if (p_gameData.ModDataBag.TryGet(MOD_DATA_KEY, out ModData existingData))
                {
                    Debug.Log("[DivisionEnablers] Mod data is present, validating...");
                    existingData.CheckValidData(p_gameData);
                }
                else
                {
                    Debug.Log("[DivisionEnablers] Injecting mod data into GameData...");
                    ModData modData = new ModData();
                    modData.InitializeData(p_gameData);
                    p_gameData.ModDataBag.TrySet(MOD_DATA_KEY, modData);
                }

                return true;
            }
        }

        [HarmonyPatch(typeof(TurnManager))]
        class Patch_TurnManager
        {
            [HarmonyPostfix]
            [HarmonyPatch(nameof(TurnManager.NextTurn))]
            static void Patch_NextTurn(bool p_sendRPC)
            {
                if (GameData.Instance == null) return;

                if (GameData.Instance.ModDataBag.TryGet(MOD_DATA_KEY, out ModData modData))
                {
                    modData.OnTurnEnd();
                    Debug.Log("[DivisionEnablers] Processed turn end for all players");

                    // Reapply recon reveals for the new current player
                    try
                    {
                        Player current = TurnManager.currPlayer;
                        if (current != null)
                        {
                            AirReconSystem.ReapplyZonesForPlayer(current);
                            Debug.Log($"[DivisionEnablers] Reapplied recon zones for {current.Country}");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        Debug.LogError($"[DivisionEnablers] Error reapplying recon zones: {ex.Message}");
                    }
                }
            }
        }

        // ==================================================================================
        // Public API for other classes to access mod data
        // ==================================================================================

        public static ModData GetModData()
        {
            if (GameData.Instance != null &&
                GameData.Instance.ModDataBag.TryGet(MOD_DATA_KEY, out ModData data))
            {
                return data;
            }
            return null;
        }

        public static PlayerEnablerData GetPlayerData(Player player)
        {
            return GetModData()?.GetPlayerData(player);
        }

        public static bool RequestEnabler(Player player, EnablerType type)
        {
            var playerData = GetPlayerData(player);
            if (playerData == null) return false;

            var enabler = playerData.GetEnabler(type);
            if (enabler == null) return false;

            if (!enabler.CanRequest(player))
            {
                // Show feedback about why request failed
                if (enabler.currentCooldown > 0)
                    UIManager.ShowMessage($"{enabler.name} on cooldown: {enabler.currentCooldown} turns remaining");
                else if (enabler.remainingUses == 0)
                    UIManager.ShowMessage($"{enabler.name} has no remaining uses this game");
                else if (!PlayerHelper.HasMoney(player, enabler.costMoney))
                    UIManager.ShowMessage($"Insufficient funds: {enabler.name} costs ${enabler.costMoney}");
                else if (enabler.isActive)
                    UIManager.ShowMessage($"{enabler.name} is already active");

                return false;
            }

            enabler.Request(player);
            UIManager.ShowMessage($"Division HQ: {enabler.name} authorized!");

            // Apply enabler effects here
            ApplyEnablerEffect(player, type);

            return true;
        }

        static void ApplyEnablerEffect(Player player, EnablerType type)
        {
            // Artillery is now handled by ArtillerySystem with targeting UI
            // Other effects can be implemented here
            switch (type)
            {
                case EnablerType.ArtillerySupport:
                    // Artillery is handled through the targeting system
                    // The effect is applied when the player clicks a target hex
                    Debug.Log($"[DivisionEnablers] Artillery support ready for {player.Country}");
                    break;

                case EnablerType.AirReconnaissance:
                    // Targeting for Air Recon is handled in UI with AirReconSystem
                    Debug.Log($"[DivisionEnablers] Air recon requested for {player.Country}");
                    break;

                case EnablerType.SupplyDrop:
                    // Supply drop targeting handled by SupplyDropSystem
                    Debug.Log($"[DivisionEnablers] Supply drop requested for {player.Country}");
                    break;

                case EnablerType.Reinforcements:
                    // Add units to reserve
                    AddReinforcements(player);
                    break;

                default:
                    Debug.LogWarning($"[DivisionEnablers] Unimplemented enabler type: {type}");
                    break;
            }
        }

        [Serializable]
        public class AirReconZone
        {
            public int x;
            public int y;
            public int remainingTurns;
            public int radius;

            public AirReconZone(int x, int y, int remainingTurns, int radius)
            {
                this.x = x;
                this.y = y;
                this.remainingTurns = remainingTurns;
                this.radius = radius;
            }
        }

        public static void AddAirReconZoneForPlayer(Player player, int x, int y, int turns, int radius)
        {
            var pdata = GetPlayerData(player);
            if (pdata == null) return;

            if (pdata.activeReconZones == null)
                pdata.activeReconZones = new List<AirReconZone>();

            pdata.activeReconZones.Add(new AirReconZone(x, y, turns, radius));
            Debug.Log($"[DivisionEnablers] Added AirRecon zone for {player.Country} at ({x},{y}) R{radius} for {turns} turns");
        }

        static void AddReinforcements(Player player)
        {
            // Example: Add 2 light infantry to reserves
            for (int i = 0; i < 2; i++)
            {
                Unit unit = Utils.GenerateNewUnit("Light infantry", player.Country);
                player.AddUnit(unit, false);
                unit.IsReserve = true;
                unit.SetDefaultProductionTime();
            }
            ReservePanelGO.instance?.RefreshDeployNotification();
            Debug.Log($"[DivisionEnablers] Added 2 reinforcement units to {player.Country}");
        }
    }
}
