// ==================================================================================
// Division Enablers Mod Entry Point
//
// This class is the entry point for the mod, called by Hex of Steel's mod system
// ==================================================================================

using HarmonyLib;
using UnityEngine;

public class DivisionEnablersModEntry : GameModification
{
    Harmony _harmony;

    public DivisionEnablersModEntry(Mod p_mod) : base(p_mod)
    {
        Debug.Log("[DivisionEnablers] Registering mod...");
    }

    public override void OnModInitialization(Mod p_mod)
    {
        Debug.Log("[DivisionEnablers] Initializing mod...");

        mod = p_mod;

        ApplyPatches();
    }

    public override void OnModUnloaded()
    {
        Debug.Log("[DivisionEnablers] Unloading mod...");
        _harmony?.UnpatchAll(_harmony.Id);
    }

    void ApplyPatches()
    {
        Debug.Log("[DivisionEnablers] Applying Harmony patches...");

        _harmony = new Harmony("com.hexofsteel.divisionenablers");
        _harmony.PatchAll();

        Debug.Log("[DivisionEnablers] Harmony patches applied");

        // Initialize UI system
        DivisionEnablersUI.Initialize();

        // Create persistent GameObject for keybind handling
        GameObject keybindHandler = new GameObject("DivisionEnablersKeybindHandler");
        keybindHandler.AddComponent<DivisionEnablersKeybindHandler>();
        keybindHandler.AddComponent<DivisionEnablersMod.ArtilleryClickHandler>();
        keybindHandler.AddComponent<DivisionEnablersMod.AirReconClickHandler>();
        GameObject.DontDestroyOnLoad(keybindHandler);

        Debug.Log("[DivisionEnablers] Mod initialized successfully! Press 'H' to toggle Division HQ");
    }
}
