// ==================================================================================
// API Explorer - Dumps complete game API to logs
//
// This utility class uses reflection to discover and log all available
// classes, methods, properties, and fields in the game's Assembly-CSharp.dll
// ==================================================================================

using System;
using System.Linq;
using System.Reflection;
using UnityEngine;

public static class APIExplorer
{
    /// <summary>
    /// Dumps complete API information for a specific class
    /// </summary>
    public static void DumpClassAPI(Type type)
    {
        if (type == null)
        {
            Debug.LogError("[APIExplorer] Type is null");
            return;
        }

        Debug.Log($"\n========================================");
        Debug.Log($"API DUMP: {type.FullName}");
        Debug.Log($"========================================\n");

        // Methods
        Debug.Log($"--- PUBLIC METHODS ({type.Name}) ---");
        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var method in methods.OrderBy(m => m.Name))
        {
            var parameters = string.Join(", ", method.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"));
            var isStatic = method.IsStatic ? "static " : "";
            Debug.Log($"  {isStatic}{method.ReturnType.Name} {method.Name}({parameters})");
        }

        // Properties
        Debug.Log($"\n--- PUBLIC PROPERTIES ({type.Name}) ---");
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var prop in properties.OrderBy(p => p.Name))
        {
            var getter = prop.CanRead ? "get" : "";
            var setter = prop.CanWrite ? "set" : "";
            var isStatic = prop.GetGetMethod()?.IsStatic == true ? "static " : "";
            Debug.Log($"  {isStatic}{prop.PropertyType.Name} {prop.Name} {{ {getter}; {setter}; }}");
        }

        // Fields
        Debug.Log($"\n--- PUBLIC FIELDS ({type.Name}) ---");
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var field in fields.OrderBy(f => f.Name))
        {
            var isStatic = field.IsStatic ? "static " : "";
            Debug.Log($"  {isStatic}{field.FieldType.Name} {field.Name}");
        }

        Debug.Log($"\n========================================\n");
    }

    /// <summary>
    /// Dumps all important game classes
    /// </summary>
    public static void DumpAllGameAPIs()
    {
        Debug.Log("\n\n╔════════════════════════════════════════════════════════════════╗");
        Debug.Log("║          HEX OF STEEL - COMPLETE API DUMP                      ║");
        Debug.Log("╚════════════════════════════════════════════════════════════════╝\n");

        // Core gameplay classes
        DumpClassAPI(typeof(GameData));
        DumpClassAPI(typeof(Player));
        DumpClassAPI(typeof(Unit));
        DumpClassAPI(typeof(TurnManager));

        // Try to get UnitGO, Tile, Province, etc. via reflection
        TryDumpClass("UnitGO");
        TryDumpClass("Tile");
        TryDumpClass("TileGO");
        TryDumpClass("Province");
        TryDumpClass("ProvinceGO");
        TryDumpClass("Building");
        TryDumpClass("Combat");
        TryDumpClass("CombatManager");
        TryDumpClass("Diplomacy");
        TryDumpClass("AI");
        TryDumpClass("UIManager");
        TryDumpClass("Policies");
        TryDumpClass("Policy");
        TryDumpClass("LocalizationManager");
        TryDumpClass("ReservePanelGO");
        TryDumpClass("PlayerSettings");
        TryDumpClass("Utils");
        TryDumpClass("ModDataBag");

        Debug.Log("\n╔════════════════════════════════════════════════════════════════╗");
        Debug.Log("║                    API DUMP COMPLETE                           ║");
        Debug.Log("╚════════════════════════════════════════════════════════════════╝\n");
    }

    static void TryDumpClass(string className)
    {
        try
        {
            // Try to find the type in the main assembly
            Type type = Type.GetType(className + ", Assembly-CSharp");
            if (type == null)
            {
                // Try without assembly qualification
                var assembly = Assembly.Load("Assembly-CSharp");
                type = assembly.GetType(className);
            }

            if (type != null)
            {
                DumpClassAPI(type);
            }
            else
            {
                Debug.LogWarning($"[APIExplorer] Could not find class: {className}");
            }
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"[APIExplorer] Error dumping {className}: {ex.Message}");
        }
    }

    /// <summary>
    /// Lists all classes in Assembly-CSharp that contain a specific term
    /// </summary>
    public static void FindClassesContaining(string searchTerm)
    {
        try
        {
            var assembly = Assembly.Load("Assembly-CSharp");
            var types = assembly.GetTypes()
                .Where(t => t.Name.ToLower().Contains(searchTerm.ToLower()))
                .OrderBy(t => t.Name);

            Debug.Log($"\n--- Classes containing '{searchTerm}' ---");
            foreach (var type in types)
            {
                Debug.Log($"  {type.FullName}");
            }
            Debug.Log($"--- Found {types.Count()} classes ---\n");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Error searching classes: {ex.Message}");
        }
    }

    /// <summary>
    /// Lists ALL classes in Assembly-CSharp (WARNING: Very verbose!)
    /// </summary>
    public static void ListAllClasses()
    {
        try
        {
            var assembly = Assembly.Load("Assembly-CSharp");
            var types = assembly.GetTypes()
                .Where(t => t.IsPublic)
                .OrderBy(t => t.Name);

            Debug.Log($"\n--- ALL PUBLIC CLASSES in Assembly-CSharp ---");
            foreach (var type in types)
            {
                Debug.Log($"  {type.FullName}");
            }
            Debug.Log($"--- Total: {types.Count()} classes ---\n");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Error listing classes: {ex.Message}");
        }
    }
}
