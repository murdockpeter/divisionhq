// ==================================================================================
// Division Enablers Keybind Handler
//
// Handles keyboard input to toggle the Division HQ UI panel
// Uses reflection to access Unity's Input class
// ==================================================================================

using UnityEngine;
using System.Reflection;
using System;

public class DivisionEnablersKeybindHandler : MonoBehaviour
{
    // Keybind to open/close the Division HQ panel (default: H key for "HQ")
    public static KeyCode toggleKey = KeyCode.H;

    private static Type _inputType;
    private static MethodInfo _getKeyDownMethod;
    private static bool _initialized = false;
    private static bool _updateCalled = false;

    void Start()
    {
        Debug.Log("[DivisionEnablers] Keybind handler Start() called");
    }

    static void Initialize()
    {
        if (_initialized) return;

        Debug.Log("[DivisionEnablers] Initializing Input system...");

        try
        {
            // Find the Input type using reflection
            _inputType = Type.GetType("UnityEngine.Input, UnityEngine.InputLegacyModule");
            if (_inputType == null)
            {
                Debug.Log("[DivisionEnablers] Trying UnityEngine assembly...");
                _inputType = Type.GetType("UnityEngine.Input, UnityEngine");
            }
            if (_inputType == null)
            {
                Debug.Log("[DivisionEnablers] Trying UnityEngine.CoreModule assembly...");
                _inputType = Type.GetType("UnityEngine.Input, UnityEngine.CoreModule");
            }

            if (_inputType != null)
            {
                Debug.Log($"[DivisionEnablers] Found Input type: {_inputType.AssemblyQualifiedName}");
                _getKeyDownMethod = _inputType.GetMethod("GetKeyDown", new Type[] { typeof(KeyCode) });

                if (_getKeyDownMethod != null)
                    Debug.Log("[DivisionEnablers] Input system initialized successfully");
                else
                    Debug.LogError("[DivisionEnablers] Could not find GetKeyDown method");
            }
            else
            {
                Debug.LogError("[DivisionEnablers] Could not find Input type in any assembly");
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[DivisionEnablers] Failed to initialize Input: {ex.Message}\n{ex.StackTrace}");
        }

        _initialized = true;
    }

    static bool GetKeyDown(KeyCode key)
    {
        Initialize();

        if (_getKeyDownMethod == null) return false;

        try
        {
            return (bool)_getKeyDownMethod.Invoke(null, new object[] { key });
        }
        catch
        {
            return false;
        }
    }

    void Update()
    {
        if (!_updateCalled)
        {
            Debug.Log("[DivisionEnablers] Update() is being called");
            _updateCalled = true;
        }

        // Only check for input during gameplay
        if (GameData.Instance == null || TurnManager.currPlayer == null)
            return;

        // Only allow human players to open the panel
        if (TurnManager.currPlayer.IsComputer)
            return;

        // Check if the toggle key is pressed
        if (GetKeyDown(toggleKey))
        {
            Debug.Log($"[DivisionEnablers] Toggle key '{toggleKey}' pressed");
            DivisionEnablersUI.TogglePanel();
        }
    }
}
