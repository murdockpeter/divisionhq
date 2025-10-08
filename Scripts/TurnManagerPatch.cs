// ==================================================================================
// Harmony Patch: TurnManager (Division Enablers UI Button)
//
// Creates the Division HQ button when a game is running
// ==================================================================================

using HarmonyLib;
using UnityEngine;

class TurnManagerPatch
{
    [HarmonyPatch(typeof(TurnManager))]
    static class Patch_TurnManager
    {
        static bool _buttonCreated = false;

        internal static void TryCreateButton()
        {
            Player currPlayer = TurnManager.currPlayer;

            // Only create button once, for human players
            if (!_buttonCreated && currPlayer != null && !currPlayer.IsComputer)
            {
                try
                {
                    Debug.Log("[DivisionEnablers] Attempting to create Division HQ button...");
                    DivisionEnablersUI.CreateDivisionHQButton();
                    _buttonCreated = true;
                    Debug.Log("[DivisionEnablers] Division HQ button created successfully");
                }
                catch (System.Exception ex)
                {
                    Debug.LogError($"[DivisionEnablers] Failed to create button: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        // Hook into NextTurn with Postfix to create button AFTER turn changes (at start of new player's turn)
        [HarmonyPostfix]
        [HarmonyPatch(nameof(TurnManager.NextTurn))]
        static void Patch_Post_NextTurn()
        {
            Player currPlayer = TurnManager.currPlayer;
            Debug.Log($"[DivisionEnablers] NextTurn postfix - buttonCreated={_buttonCreated}, currPlayer={currPlayer?.Country}, isComputer={currPlayer?.IsComputer}");
            TryCreateButton();
        }
    }

}