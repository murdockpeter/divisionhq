// ==================================================================================
// API Explorer Complete - Dumps ALL game API including private members
//
// This utility uses reflection + Harmony's AccessTools to discover and document
// ALL classes, methods, properties, and fields (both public AND private)
// in the game's Assembly-CSharp.dll
//
// IMPORTANT: With Harmony, you can patch private methods just as easily as public!
// ==================================================================================

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using HarmonyLib;

public static class APIExplorerComplete
{
    private static StringBuilder output = new StringBuilder();
    private static string outputPath = "";

    /// <summary>
    /// Dumps COMPLETE API information for a specific class (public AND private)
    /// </summary>
    public static void DumpClassAPIComplete(Type type)
    {
        if (type == null)
        {
            output.AppendLine("[ERROR] Type is null");
            return;
        }

        output.AppendLine();
        output.AppendLine($"## {type.FullName}");
        output.AppendLine();

        // Get base type info
        if (type.BaseType != null && type.BaseType != typeof(object))
        {
            output.AppendLine($"**Base Class:** `{type.BaseType.FullName}`");
            output.AppendLine();
        }

        // Show if type is static, abstract, sealed, etc.
        var typeModifiers = new System.Collections.Generic.List<string>();
        if (type.IsAbstract && type.IsSealed) typeModifiers.Add("static");
        else if (type.IsAbstract) typeModifiers.Add("abstract");
        else if (type.IsSealed) typeModifiers.Add("sealed");
        if (typeModifiers.Count > 0)
        {
            output.AppendLine($"**Modifiers:** `{string.Join(", ", typeModifiers)}`");
            output.AppendLine();
        }

        // PUBLIC METHODS
        output.AppendLine($"### Public Methods");
        output.AppendLine();
        var publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        DumpMethods(publicMethods, "public");

        // PRIVATE METHODS (accessible via Harmony!)
        output.AppendLine($"### Private Methods");
        output.AppendLine();
        output.AppendLine("*These methods can be patched using Harmony's AccessTools*");
        output.AppendLine();
        var privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        DumpMethods(privateMethods, "private");

        // PUBLIC PROPERTIES
        output.AppendLine($"### Public Properties");
        output.AppendLine();
        var publicProperties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        DumpProperties(publicProperties, "public");

        // PRIVATE PROPERTIES (accessible via Harmony!)
        output.AppendLine($"### Private Properties");
        output.AppendLine();
        output.AppendLine("*These properties can be accessed using Harmony's Traverse or AccessTools*");
        output.AppendLine();
        var privateProperties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        DumpProperties(privateProperties, "private");

        // PUBLIC FIELDS
        output.AppendLine($"### Public Fields");
        output.AppendLine();
        var publicFields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        DumpFields(publicFields, "public");

        // PRIVATE FIELDS (accessible via Harmony!)
        output.AppendLine($"### Private Fields");
        output.AppendLine();
        output.AppendLine("*These fields can be accessed using Harmony's Traverse or AccessTools*");
        output.AppendLine();
        var privateFields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        DumpFields(privateFields, "private");

        // NESTED TYPES (inner classes)
        var nestedTypes = type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic);
        if (nestedTypes.Length > 0)
        {
            output.AppendLine($"### Nested Types");
            output.AppendLine();
            foreach (var nested in nestedTypes.OrderBy(t => t.Name))
            {
                var visibility = nested.IsPublic || nested.IsNestedPublic ? "public" : "private";
                output.AppendLine($"- `{visibility} class {nested.Name}`");
            }
            output.AppendLine();
        }

        // HARMONY USAGE EXAMPLES
        output.AppendLine($"### Harmony Usage Examples");
        output.AppendLine();
        output.AppendLine("```csharp");
        output.AppendLine($"// Patching a private method:");
        output.AppendLine($"[HarmonyPatch(typeof({type.Name}), \"PrivateMethodName\", MethodType.Normal)]");
        output.AppendLine($"class Patch_{type.Name}_PrivateMethod {{ }}");
        output.AppendLine();
        output.AppendLine($"// Accessing a private field:");
        output.AppendLine($"var instance = GetInstanceSomehow();");
        output.AppendLine($"var privateField = Traverse.Create(instance).Field(\"privateFieldName\").GetValue<Type>();");
        output.AppendLine();
        output.AppendLine($"// Or using AccessTools:");
        output.AppendLine($"var fieldInfo = AccessTools.Field(typeof({type.Name}), \"privateFieldName\");");
        output.AppendLine($"var value = fieldInfo.GetValue(instance);");
        output.AppendLine("```");
        output.AppendLine();

        output.AppendLine("---");
        output.AppendLine();
    }

    private static void DumpMethods(MethodInfo[] methods, string visibility)
    {
        if (methods.Length == 0)
        {
            output.AppendLine($"*No {visibility} methods*");
            output.AppendLine();
            return;
        }

        // Filter out compiler-generated and property accessor methods
        var filteredMethods = methods.Where(m =>
            !m.Name.StartsWith("get_") &&
            !m.Name.StartsWith("set_") &&
            !m.Name.StartsWith("add_") &&
            !m.Name.StartsWith("remove_") &&
            !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false).Any()
        ).OrderBy(m => m.Name);

        foreach (var method in filteredMethods)
        {
            var parameters = string.Join(", ", method.GetParameters().Select(p =>
            {
                var paramStr = $"{p.ParameterType.Name} {p.Name}";
                if (p.HasDefaultValue)
                {
                    var defaultVal = p.DefaultValue == null ? "null" : p.DefaultValue.ToString();
                    paramStr += $" = {defaultVal}";
                }
                return paramStr;
            }));

            var modifiers = new System.Collections.Generic.List<string>();
            if (method.IsStatic) modifiers.Add("static");
            if (method.IsVirtual && !method.IsFinal) modifiers.Add("virtual");
            if (method.IsAbstract) modifiers.Add("abstract");

            var modifierStr = modifiers.Count > 0 ? string.Join(" ", modifiers) + " " : "";

            output.AppendLine($"- `{visibility} {modifierStr}{method.ReturnType.Name} {method.Name}({parameters})`");
        }
        output.AppendLine();
    }

    private static void DumpProperties(PropertyInfo[] properties, string visibility)
    {
        if (properties.Length == 0)
        {
            output.AppendLine($"*No {visibility} properties*");
            output.AppendLine();
            return;
        }

        foreach (var prop in properties.OrderBy(p => p.Name))
        {
            var getter = prop.CanRead ? "get" : "";
            var setter = prop.CanWrite ? "set" : "";
            var accessors = string.Join("; ", new[] { getter, setter }.Where(s => !string.IsNullOrEmpty(s)));

            var getMethod = prop.GetGetMethod(true);
            var isStatic = getMethod?.IsStatic == true ? "static " : "";

            output.AppendLine($"- `{visibility} {isStatic}{prop.PropertyType.Name} {prop.Name}` {{ {accessors} }}");
        }
        output.AppendLine();
    }

    private static void DumpFields(FieldInfo[] fields, string visibility)
    {
        if (fields.Length == 0)
        {
            output.AppendLine($"*No {visibility} fields*");
            output.AppendLine();
            return;
        }

        foreach (var field in fields.OrderBy(f => f.Name))
        {
            var modifiers = new System.Collections.Generic.List<string>();
            if (field.IsStatic) modifiers.Add("static");
            if (field.IsInitOnly) modifiers.Add("readonly");
            if (field.IsLiteral) modifiers.Add("const");

            var modifierStr = modifiers.Count > 0 ? string.Join(" ", modifiers) + " " : "";

            output.AppendLine($"- `{visibility} {modifierStr}{field.FieldType.Name} {field.Name}`");
        }
        output.AppendLine();
    }

    /// <summary>
    /// Dumps ALL classes (including private/internal) with ALL members
    /// </summary>
    public static void DumpCompleteAPIToFile(string filePath = null)
    {
        output = new StringBuilder();

        if (string.IsNullOrEmpty(filePath))
        {
            outputPath = Path.Combine(Application.dataPath, "..", "HexOfSteel_API_COMPLETE_WITH_PRIVATE.md");
        }
        else
        {
            outputPath = filePath;
        }

        Debug.Log($"[APIExplorer] Starting COMPLETE API dump (including private members) to: {outputPath}");

        // Header
        output.AppendLine("# Hex Of Steel - COMPLETE API Reference (Public + Private)");
        output.AppendLine();
        output.AppendLine($"*Generated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}*");
        output.AppendLine();
        output.AppendLine("This document contains a **comprehensive** reference of ALL classes (public, internal, and private)");
        output.AppendLine("and ALL their members (public AND private) available in Hex Of Steel.");
        output.AppendLine();
        output.AppendLine("**With Harmony, you can access and patch EVERYTHING in this document!**");
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Add usage guide
        output.AppendLine("## How to Use Private Members with Harmony");
        output.AppendLine();
        output.AppendLine("### Patching Private Methods");
        output.AppendLine("```csharp");
        output.AppendLine("[HarmonyPatch(typeof(ClassName), \"PrivateMethodName\")]");
        output.AppendLine("class MyPatch {");
        output.AppendLine("    static bool Prefix(ClassName __instance) {");
        output.AppendLine("        // Your code here");
        output.AppendLine("        return true; // return false to skip original method");
        output.AppendLine("    }");
        output.AppendLine("}");
        output.AppendLine("```");
        output.AppendLine();
        output.AppendLine("### Accessing Private Fields with Traverse");
        output.AppendLine("```csharp");
        output.AppendLine("var instance = GetYourInstance();");
        output.AppendLine("var privateValue = Traverse.Create(instance).Field(\"privateFieldName\").GetValue<int>();");
        output.AppendLine("Traverse.Create(instance).Field(\"privateFieldName\").SetValue(42);");
        output.AppendLine("```");
        output.AppendLine();
        output.AppendLine("### Accessing Private Fields with AccessTools");
        output.AppendLine("```csharp");
        output.AppendLine("var fieldInfo = AccessTools.Field(typeof(ClassName), \"privateFieldName\");");
        output.AppendLine("var value = fieldInfo.GetValue(instance);");
        output.AppendLine("fieldInfo.SetValue(instance, newValue);");
        output.AppendLine("```");
        output.AppendLine();
        output.AppendLine("### Calling Private Methods");
        output.AppendLine("```csharp");
        output.AppendLine("var methodInfo = AccessTools.Method(typeof(ClassName), \"PrivateMethodName\");");
        output.AppendLine("methodInfo.Invoke(instance, new object[] { param1, param2 });");
        output.AppendLine("```");
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Discover ALL classes (including private/internal)
        var discoveredClasses = DiscoverAllClassesComplete();

        // Table of Contents
        output.AppendLine("## Table of Contents");
        output.AppendLine();
        output.AppendLine($"**Total Classes: {discoveredClasses.Count}**");
        output.AppendLine();

        int index = 1;
        foreach (var type in discoveredClasses.OrderBy(t => t.FullName ?? t.Name))
        {
            var visibility = type.IsPublic ? "public" : "internal/private";
            var name = type.FullName ?? type.Name;
            output.AppendLine($"{index}. [{name}](#{name.ToLower().Replace(".", "").Replace("`", "")}) *({visibility})*");
            index++;
        }
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Dump all classes with all members
        foreach (var type in discoveredClasses.OrderBy(t => t.FullName ?? t.Name))
        {
            DumpClassAPIComplete(type);
        }

        // Footer
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();
        output.AppendLine("## End of Complete API Reference");
        output.AppendLine();
        output.AppendLine("*This documentation includes ALL classes and members (public and private)*");
        output.AppendLine();
        output.AppendLine("*Generated using APIExplorerComplete with Harmony reflection support*");

        // Write to file
        try
        {
            File.WriteAllText(outputPath, output.ToString());
            Debug.Log($"[APIExplorer] ✓ COMPLETE API documentation written successfully to: {outputPath}");
            Debug.Log($"[APIExplorer] Total classes documented: {discoveredClasses.Count}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Failed to write file: {ex.Message}");
        }
    }

    /// <summary>
    /// Discovers ALL classes in Assembly-CSharp (public, internal, and private)
    /// </summary>
    private static System.Collections.Generic.List<Type> DiscoverAllClassesComplete()
    {
        var classList = new System.Collections.Generic.List<Type>();

        try
        {
            var assembly = Assembly.Load("Assembly-CSharp");
            // Get ALL types, not just public ones!
            var types = assembly.GetTypes()
                .Where(t => !t.IsNested) // Skip nested types (we'll show them under their parent)
                .OrderBy(t => t.FullName ?? t.Name);

            foreach (var type in types)
            {
                classList.Add(type);
            }

            Debug.Log($"[APIExplorer] Discovered {classList.Count} classes (including private/internal)");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Error discovering classes: {ex.Message}");
        }

        return classList;
    }

    /// <summary>
    /// Dumps only core classes but with ALL their members (public + private)
    /// </summary>
    public static void DumpCoreClassesWithPrivate(string filePath = null)
    {
        output = new StringBuilder();

        if (string.IsNullOrEmpty(filePath))
        {
            outputPath = Path.Combine(Application.dataPath, "..", "HexOfSteel_API_Core_With_Private.md");
        }
        else
        {
            outputPath = filePath;
        }

        Debug.Log($"[APIExplorer] Starting core API dump with private members to: {outputPath}");

        // Header
        output.AppendLine("# Hex Of Steel - Core API Reference (With Private Members)");
        output.AppendLine();
        output.AppendLine($"*Generated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}*");
        output.AppendLine();
        output.AppendLine("Essential classes for Hex Of Steel modding, including private members accessible via Harmony.");
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Core classes list
        var coreClassNames = new[]
        {
            "GameData",
            "Player",
            "Unit",
            "TurnManager",
            "UnitGO",
            "Tile",
            "TileGO",
            "Province",
            "ProvinceGO",
            "Building",
            "Combat",
            "CombatManager",
            "Diplomacy",
            "AI",
            "UIManager",
            "Policies",
            "Policy",
            "LocalizationManager",
            "ReservePanelGO",
            "PlayerSettings",
            "Utils",
            "ModDataBag",
            "GameManager",
            "MapManager",
            "InputManager"
        };

        foreach (var className in coreClassNames)
        {
            TryDumpClassComplete(className);
        }

        // Footer
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();
        output.AppendLine("## End of Core API Reference");

        // Write to file
        try
        {
            File.WriteAllText(outputPath, output.ToString());
            Debug.Log($"[APIExplorer] ✓ Core API (with private members) written successfully to: {outputPath}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Failed to write file: {ex.Message}");
        }
    }

    private static void TryDumpClassComplete(string className)
    {
        try
        {
            Type type = Type.GetType(className + ", Assembly-CSharp");
            if (type == null)
            {
                var assembly = Assembly.Load("Assembly-CSharp");
                type = assembly.GetType(className);
            }

            if (type != null)
            {
                DumpClassAPIComplete(type);
            }
            else
            {
                output.AppendLine($"## {className}");
                output.AppendLine();
                output.AppendLine("*Could not load this class via reflection*");
                output.AppendLine();
                output.AppendLine("---");
                output.AppendLine();
            }
        }
        catch (Exception ex)
        {
            output.AppendLine($"## {className}");
            output.AppendLine();
            output.AppendLine($"*Error: {ex.Message}*");
            output.AppendLine();
            output.AppendLine("---");
            output.AppendLine();
        }
    }
}
