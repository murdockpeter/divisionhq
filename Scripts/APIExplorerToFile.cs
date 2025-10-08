// ==================================================================================
// API Explorer To File - Dumps complete game API to markdown file
//
// This utility class uses reflection to discover and log all available
// classes, methods, properties, and fields in the game's Assembly-CSharp.dll
// and writes them to a markdown file for documentation purposes
// ==================================================================================

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

public static class APIExplorerToFile
{
    private static StringBuilder output = new StringBuilder();
    private static string outputPath = "";

    /// <summary>
    /// Dumps complete API information for a specific class to the output buffer
    /// </summary>
    public static void DumpClassAPI(Type type)
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

        // Methods
        output.AppendLine($"### Public Methods");
        output.AppendLine();
        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);

        if (methods.Length == 0)
        {
            output.AppendLine("*No public methods*");
        }
        else
        {
            foreach (var method in methods.OrderBy(m => m.Name))
            {
                var parameters = string.Join(", ", method.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"));
                var isStatic = method.IsStatic ? "static " : "";
                output.AppendLine($"- `{isStatic}{method.ReturnType.Name} {method.Name}({parameters})`");
            }
        }
        output.AppendLine();

        // Properties
        output.AppendLine($"### Public Properties");
        output.AppendLine();
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);

        if (properties.Length == 0)
        {
            output.AppendLine("*No public properties*");
        }
        else
        {
            foreach (var prop in properties.OrderBy(p => p.Name))
            {
                var getter = prop.CanRead ? "get" : "";
                var setter = prop.CanWrite ? "set" : "";
                var accessors = string.Join("; ", new[] { getter, setter }.Where(s => !string.IsNullOrEmpty(s)));
                var isStatic = prop.GetGetMethod()?.IsStatic == true ? "static " : "";
                output.AppendLine($"- `{isStatic}{prop.PropertyType.Name} {prop.Name}` {{ {accessors} }}");
            }
        }
        output.AppendLine();

        // Fields
        output.AppendLine($"### Public Fields");
        output.AppendLine();
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);

        if (fields.Length == 0)
        {
            output.AppendLine("*No public fields*");
        }
        else
        {
            foreach (var field in fields.OrderBy(f => f.Name))
            {
                var isStatic = field.IsStatic ? "static " : "";
                var isReadonly = field.IsInitOnly ? "readonly " : "";
                output.AppendLine($"- `{isStatic}{isReadonly}{field.FieldType.Name} {field.Name}`");
            }
        }
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();
    }

    /// <summary>
    /// Dumps all important game classes to a markdown file
    /// </summary>
    public static void DumpAllGameAPIsToFile(string filePath = null)
    {
        // Reset the output buffer
        output = new StringBuilder();

        // Determine output path
        if (string.IsNullOrEmpty(filePath))
        {
            outputPath = Path.Combine(Application.dataPath, "..", "HexOfSteel_API_Complete.md");
        }
        else
        {
            outputPath = filePath;
        }

        Debug.Log($"[APIExplorer] Starting API dump to: {outputPath}");

        // Header
        output.AppendLine("# Hex Of Steel - Complete API Reference");
        output.AppendLine();
        output.AppendLine($"*Generated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}*");
        output.AppendLine();
        output.AppendLine("This document contains a comprehensive reference of all public classes, methods, properties, and fields available in Hex Of Steel's modding API.");
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Table of Contents
        output.AppendLine("## Table of Contents");
        output.AppendLine();

        // First, discover all available classes
        var discoveredClasses = DiscoverAllClasses();

        // Generate TOC
        int index = 1;
        foreach (var className in discoveredClasses.OrderBy(c => c))
        {
            output.AppendLine($"{index}. [{className}](#{className.ToLower().Replace(".", "")})");
            index++;
        }
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Dump all classes
        foreach (var className in discoveredClasses.OrderBy(c => c))
        {
            TryDumpClass(className);
        }

        // Footer
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();
        output.AppendLine("## End of API Reference");
        output.AppendLine();
        output.AppendLine("*This documentation was automatically generated using APIExplorer*");

        // Write to file
        try
        {
            File.WriteAllText(outputPath, output.ToString());
            Debug.Log($"[APIExplorer] ✓ API documentation written successfully to: {outputPath}");
            Debug.Log($"[APIExplorer] Total classes documented: {discoveredClasses.Count}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Failed to write file: {ex.Message}");
        }
    }

    /// <summary>
    /// Discovers all public classes in Assembly-CSharp
    /// </summary>
    private static System.Collections.Generic.List<string> DiscoverAllClasses()
    {
        var classList = new System.Collections.Generic.List<string>();

        try
        {
            var assembly = Assembly.Load("Assembly-CSharp");
            var types = assembly.GetTypes()
                .Where(t => t.IsPublic && !t.IsNested)
                .OrderBy(t => t.FullName ?? t.Name);

            foreach (var type in types)
            {
                classList.Add(type.FullName ?? type.Name);
            }

            Debug.Log($"[APIExplorer] Discovered {classList.Count} public classes");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Error discovering classes: {ex.Message}");
        }

        return classList;
    }

    /// <summary>
    /// Attempts to dump a class by name
    /// </summary>
    private static void TryDumpClass(string className)
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

    /// <summary>
    /// Quick dump of core classes only (lighter version)
    /// </summary>
    public static void DumpCoreClassesOnly(string filePath = null)
    {
        // Reset the output buffer
        output = new StringBuilder();

        // Determine output path
        if (string.IsNullOrEmpty(filePath))
        {
            outputPath = Path.Combine(Application.dataPath, "..", "HexOfSteel_API_Core.md");
        }
        else
        {
            outputPath = filePath;
        }

        Debug.Log($"[APIExplorer] Starting core API dump to: {outputPath}");

        // Header
        output.AppendLine("# Hex Of Steel - Core API Reference");
        output.AppendLine();
        output.AppendLine($"*Generated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}*");
        output.AppendLine();
        output.AppendLine("This document contains essential classes for Hex Of Steel modding.");
        output.AppendLine();
        output.AppendLine("---");
        output.AppendLine();

        // Core classes list
        var coreClasses = new[]
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
            "ModDataBag"
        };

        foreach (var className in coreClasses)
        {
            TryDumpClass(className);
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
            Debug.Log($"[APIExplorer] ✓ Core API documentation written successfully to: {outputPath}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[APIExplorer] Failed to write file: {ex.Message}");
        }
    }
}
