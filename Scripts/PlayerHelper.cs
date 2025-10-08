// ==================================================================================
// Player Helper - Reflection-based API access
//
// Provides safe access to Player properties that may not be visible at compile time
// but exist at runtime in the actual game DLL
//
// ==================================================================================

using System;
using System.Reflection;
using UnityEngine;

public static class PlayerHelper
{
    private static FieldInfo _moneyField;
    private static PropertyInfo _moneyProperty;
    private static MethodInfo _moneyMethod;
    private static bool _initialized = false;

    static void Initialize()
    {
        if (_initialized) return;

        Type playerType = typeof(Player);

        Debug.Log($"[PlayerHelper] Searching for money in Player type...");

        // List all methods containing "money"
        var methods = playerType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
        Debug.Log($"[PlayerHelper] Found {methods.Length} public instance methods");
        foreach (var method in methods)
        {
            if (method.Name.ToLower().Contains("money"))
                Debug.Log($"[PlayerHelper] Method: {method.Name} returns {method.ReturnType.Name}");
        }

        // List all fields containing "money"
        var fields = playerType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Debug.Log($"[PlayerHelper] Found {fields.Length} public instance fields");
        foreach (var field in fields)
        {
            if (field.Name.ToLower().Contains("money"))
                Debug.Log($"[PlayerHelper] Field: {field.Name} type {field.FieldType.Name}");
        }

        // List all properties containing "money"
        var properties = playerType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        Debug.Log($"[PlayerHelper] Found {properties.Length} public instance properties");
        foreach (var prop in properties)
        {
            if (prop.Name.ToLower().Contains("money"))
                Debug.Log($"[PlayerHelper] Property: {prop.Name} type {prop.PropertyType.Name}");
        }

        // Try to find MoneyAmount property (the actual property name in the game)
        _moneyProperty = playerType.GetProperty("MoneyAmount", BindingFlags.Public | BindingFlags.Instance);

        // Fallback: Try GetMoney method
        if (_moneyProperty == null)
            _moneyMethod = playerType.GetMethod("GetMoney", BindingFlags.Public | BindingFlags.Instance);

        // Fallback: Try Money as a field (try both uppercase and lowercase)
        if (_moneyProperty == null && _moneyMethod == null)
        {
            _moneyField = playerType.GetField("Money", BindingFlags.Public | BindingFlags.Instance);
            if (_moneyField == null)
                _moneyField = playerType.GetField("money", BindingFlags.Public | BindingFlags.Instance);
        }

        _initialized = true;

        if (_moneyProperty != null)
            Debug.Log($"[PlayerHelper] Found Money as property: {_moneyProperty.Name}");
        else if (_moneyMethod != null)
            Debug.Log("[PlayerHelper] Found GetMoney() method");
        else if (_moneyField != null)
            Debug.Log($"[PlayerHelper] Found Money as field: {_moneyField.Name}");
        else
            Debug.LogWarning("[PlayerHelper] Could not find Money method, field, or property");
    }

    public static int GetMoney(Player player)
    {
        if (player == null) return 0;

        Initialize();

        try
        {
            // Try property first (MoneyAmount is the actual property name)
            if (_moneyProperty != null)
            {
                int money = (int)_moneyProperty.GetValue(player);
                Debug.Log($"[PlayerHelper] Got money for {player.Country}: {money}");
                return money;
            }
            // Try method
            else if (_moneyMethod != null)
                return (int)_moneyMethod.Invoke(player, null);
            // Try field
            else if (_moneyField != null)
                return (int)_moneyField.GetValue(player);
        }
        catch (Exception ex)
        {
            Debug.LogError($"[PlayerHelper] Error getting Money: {ex.Message}");
        }

        return 0;
    }

    public static bool HasMoney(Player player, int amount)
    {
        return GetMoney(player) >= amount;
    }
}
