# Hex Of Steel - API Explorer Guide

## Overview

This guide explains how to use the API Explorer tools to generate comprehensive documentation of all public classes available in Hex Of Steel for modding purposes.

---

## Available API Explorer Tools

### 1. **APIExplorer.cs** (Console/Log Output)
The original API explorer that outputs to Unity's Debug.Log (visible in Player.log).

**Methods:**
- `DumpAllGameAPIs()` - Dumps all important game classes to the log
- `DumpClassAPI(Type type)` - Dumps a specific class's API to the log
- `FindClassesContaining(string searchTerm)` - Searches for classes by name
- `ListAllClasses()` - Lists all public classes in Assembly-CSharp

### 2. **APIExplorerToFile.cs** (Markdown File Output)
Enhanced version that generates beautifully formatted markdown documentation files.

**Methods:**
- `DumpAllGameAPIsToFile(string filePath = null)` - Generates complete API documentation for ALL public classes
- `DumpCoreClassesOnly(string filePath = null)` - Generates documentation for core/essential classes only
- `DumpClassAPI(Type type)` - Dumps a specific class to the markdown buffer

---

## How to Generate API Documentation

### Step 1: Enable API Documentation Generation

Edit [ExampleMod.cs](Scripts/ExampleMod.cs) and uncomment ONE of the following lines (around line 85):

```csharp
// For COMPLETE documentation (all public classes):
APIExplorerToFile.DumpAllGameAPIsToFile();

// For CORE classes only (recommended for beginners):
APIExplorerToFile.DumpCoreClassesOnly();
```

**Example:**
```csharp
void ApplyPatches()
{
    Debug.Log($"[MOD:{modName}] Applying Patches...");

    _harmony = new Harmony("com.hexofsteel." + mod.name);
    _harmony.PatchAll();

    DivisionEnablersUI.Initialize();

    GameObject keybindHandler = new GameObject("DivisionEnablersKeybindHandler");
    keybindHandler.AddComponent<DivisionEnablersKeybindHandler>();
    GameObject.DontDestroyOnLoad(keybindHandler);

    // ENABLE API DOCUMENTATION GENERATION:
    APIExplorerToFile.DumpAllGameAPIsToFile();  // ← Uncomment this line!

    Debug.Log($"[MOD:{modName}] Division Enablers initialized successfully!");
}
```

### Step 2: Build the Mod

```bash
dotnet build
```

The compiled DLL will be output to: `output/net48/DivisionEnablers.dll`

### Step 3: Install the Mod

1. Copy `output/net48/DivisionEnablers.dll` to your Hex Of Steel mods folder
2. The mods folder is typically located at:
   - Windows: `%APPDATA%\..\LocalLow\Crescent Moon Games\Hex of Steel\Mods\`
   - Or in your Steam installation: `Steam\steamapps\common\Hex of Steel\Mods\`

### Step 4: Run the Game

1. Launch Hex Of Steel
2. The mod will automatically initialize when the game starts
3. The API documentation will be generated immediately

### Step 5: Find Your Documentation

The generated markdown file will be located in the game's root directory:

- **Full API:** `HexOfSteel_API_Complete.md`
- **Core API:** `HexOfSteel_API_Core.md`

Typical location:
```
Steam\steamapps\common\Hex of Steel\HexOfSteel_API_Complete.md
```

### Step 6: Disable After First Run (Optional)

Once you have your documentation, you should **comment out** the API explorer line again to prevent regenerating the file every time you launch the game:

```csharp
// APIExplorerToFile.DumpAllGameAPIsToFile();  // ← Comment it back out
```

---

## Output File Formats

### Complete API Documentation
**File:** `HexOfSteel_API_Complete.md`

Contains:
- **All public classes** in Assembly-CSharp
- Full table of contents with links
- For each class:
  - Base class information
  - Public methods with parameters and return types
  - Public properties with get/set accessors
  - Public fields with type information
  - Static vs instance member indicators

**Size:** Can be very large (hundreds of classes)

### Core API Documentation
**File:** `HexOfSteel_API_Core.md`

Contains only essential modding classes:
- `GameData`
- `Player`
- `Unit`
- `TurnManager`
- `UnitGO`
- `Tile` / `TileGO`
- `Province` / `ProvinceGO`
- `Building`
- `Combat` / `CombatManager`
- `Diplomacy`
- `AI`
- `UIManager`
- `Policies` / `Policy`
- `LocalizationManager`
- `ReservePanelGO`
- `PlayerSettings`
- `Utils`
- `ModDataBag`

**Size:** Much more manageable, recommended for getting started

---

## Example Documentation Output

Here's what the generated markdown looks like:

```markdown
## GameData

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `static GameData GetInstance()`
- `Player GetPlayer(int playerId)`
- `void SaveGame(string saveName)`
- `void LoadGame(string saveName)`

### Public Properties

- `List<Player> players` { get; set; }
- `TurnManager turnManager` { get; }
- `int currentTurn` { get; set; }

### Public Fields

- `static GameData instance`
- `bool isMultiplayer`
```

---

## Advanced Usage

### Exploring Specific Classes

If you want to document only specific classes, you can create a custom call:

```csharp
// In ExampleMod.cs ApplyPatches() method
var output = new StringBuilder();
APIExplorerToFile.DumpClassAPI(typeof(Unit));
APIExplorerToFile.DumpClassAPI(typeof(Player));
// Write custom output...
```

### Searching for Classes

Use the original APIExplorer to search for classes in the log:

```csharp
APIExplorer.FindClassesContaining("Combat");  // Find all combat-related classes
APIExplorer.ListAllClasses();                 // List everything (very verbose!)
```

Check `Player.log` after running the game to see the results.

### Custom Output Path

You can specify a custom path for the output file:

```csharp
string customPath = @"C:\MyMods\Documentation\HexOfSteelAPI.md";
APIExplorerToFile.DumpAllGameAPIsToFile(customPath);
```

---

## Troubleshooting

### "Could not load this class via reflection"
Some classes might be obfuscated or internal. This is normal and expected for some game classes.

### File not generated
1. Check that the mod is loading (look for log messages in `Player.log`)
2. Verify you uncommented the right line in [ExampleMod.cs](Scripts/ExampleMod.cs)
3. Make sure you rebuilt the mod after making changes
4. Check file permissions in the game directory

### Player.log location
- Windows: `%APPDATA%\..\LocalLow\Crescent Moon Games\Hex of Steel\Player.log`
- You can also use the PlayerLogOpener.cs utility (press F12 in-game to open the log)

### Build errors
Make sure all required library DLLs are present in the `Libraries` folder:
- `0Harmony.dll`
- `Assembly-CSharp.dll`
- `UnityEngine.CoreModule.dll`
- etc.

---

## Tips for Using the Generated Documentation

1. **Start with Core API** - Use `DumpCoreClassesOnly()` first to understand the essential classes
2. **Search efficiently** - Use Ctrl+F in your markdown viewer to find specific methods
3. **Cross-reference** - Compare with the existing [API_REFERENCE.md](API_REFERENCE.md) and [HARMONY_MODDING_MANUAL.md](HARMONY_MODDING_MANUAL.md)
4. **Test as you go** - Try calling methods you discover to verify they work as expected
5. **Look for patterns** - Similar classes often have similar method signatures

---

## Next Steps

After generating your API documentation:

1. **Study the core classes** - Focus on `GameData`, `Player`, `Unit`, and `TurnManager` first
2. **Experiment with patches** - Use Harmony to hook into methods you've discovered
3. **Read existing examples** - Check the other scripts in this project for real-world usage
4. **Join the community** - Share your findings and learn from other modders

---

## Additional Resources

- [API_REFERENCE.md](API_REFERENCE.md) - Manual API reference with examples
- [HARMONY_MODDING_MANUAL.md](HARMONY_MODDING_MANUAL.md) - Harmony patching guide
- [Harmony Documentation](https://harmony.pardeike.net/) - Official Harmony docs
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/) - Unity API documentation

---

**Happy Modding! 🎮**

*Generated by the Hex Of Steel Modding Community*
