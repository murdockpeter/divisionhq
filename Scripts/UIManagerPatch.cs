// ==================================================================================
// UIManager Patch
//
// Prevents the game from hiding counters when our Division HQ UI is open
// ==================================================================================

using HarmonyLib;
using UnityEngine;

namespace DivisionEnablersMod
{
    [HarmonyPatch(typeof(UIManager))]
    [HarmonyPatch("ShowHideAllUnits")]
    public class UIManager_ShowHideAllUnits_Patch
    {
        static bool Prefix(bool p_show)
        {
            Debug.Log($"[UIManagerPatch] ShowHideAllUnits called with p_show={p_show}, panelOpen={DivisionEnablersUI.IsPanelOpen()}");

            // Always prevent hiding units (p_show=False means hide)
            if (!p_show)
            {
                Debug.Log("[DivisionEnablers] Prevented game from hiding units");
                return false; // Skip the original method
            }
            return true; // Allow showing units
        }
    }

    [HarmonyPatch(typeof(UIManager))]
    [HarmonyPatch("Update")]
    public class UIManager_Update_Patch
    {
        static bool _lastPanelState = false;
        static bool _lastUIState = false;

        static void Postfix()
        {
            bool panelOpen = DivisionEnablersUI.IsPanelOpen();
            bool uiOpen = UIManager.isUIOpen;

            // Log state changes
            if (panelOpen != _lastPanelState || uiOpen != _lastUIState)
            {
                Debug.Log($"[UIManagerPatch] Panel: {_lastPanelState}->{panelOpen}, UIManager.isUIOpen: {_lastUIState}->{uiOpen}");
                _lastPanelState = panelOpen;
                _lastUIState = uiOpen;
            }

            // After UIManager.Update runs, if our panel is open, ensure units stay visible
            if (panelOpen)
            {
                // Force isUIOpen to false so counters remain visible
                UIManager.isUIOpen = false;
            }
        }
    }
}
