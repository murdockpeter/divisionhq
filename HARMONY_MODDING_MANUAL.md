# Hex of Steel - Complete Harmony Modding Manual

**Version:** 1.0
**Last Updated:** 2025
**Author:** Claude & Community

---

## Table of Contents

1. [Introduction to Harmony](#introduction-to-harmony)
2. [Getting Started](#getting-started)
3. [Harmony Patching Fundamentals](#harmony-patching-fundamentals)
4. [Game API Reference](#game-api-reference)
5. [Common Modding Patterns](#common-modding-patterns)
6. [Advanced Techniques](#advanced-techniques)
7. [Debugging & Troubleshooting](#debugging--troubleshooting)
8. [Complete Examples](#complete-examples)
9. [Best Practices](#best-practices)
10. [API Explorer](#api-explorer)

---

## Introduction to Harmony

### What is Harmony?

Harmony is a .NET library that allows you to patch, replace, or extend methods in existing assemblies at runtime. In Hex of Steel, this means you can:

- **Modify game behavior** without touching the original game files
- **Add new features** by hooking into existing game systems
- **Access private members** of game classes using reflection
- **Run custom code** before, after, or instead of game methods

### Why Harmony for Hex of Steel?

- ✅ **Non-invasive:** No game files are modified
- ✅ **Compatible:** Multiple mods can coexist
- ✅ **Powerful:** Access to almost any game functionality
- ✅ **Persistent:** Your mod data can be saved with the game

---

## Getting Started

### Prerequisites

1. **.NET 8 SDK** - Download from [https://dotnet.microsoft.com/download/dotnet/8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
2. **Code Editor** - Visual Studio Code recommended
3. **Hex of Steel** - Obviously!

### Project Structure

```
YourMod/
├── Scripts/
│   ├── YourMod.cs              # Main entry point
│   ├── YourPatches.cs          # Your Harmony patches
│   └── YourUIComponents.cs     # Custom UI (optional)
├── Libraries/
│   ├── 0Harmony.dll            # Harmony library
│   ├── Assembly-CSharp.dll     # Game's main assembly
│   └── [Unity DLLs]            # Unity engine references
├── YourMod.csproj              # Project file
└── README.txt                  # Documentation
```

### Basic Mod Template

```csharp
using HarmonyLib;
using UnityEngine;

public class YourMod : GameModification
{
    Harmony _harmony;

    public YourMod(Mod p_mod) : base(p_mod)
    {
        Debug.Log($"[{p_mod.name}] Registering...");
    }

    public override void OnModInitialization(Mod p_mod)
    {
        Debug.Log($"[{p_mod.name}] Initializing...");

        _harmony = new Harmony($"com.hexofsteel.{p_mod.name}");
        _harmony.PatchAll(); // Apply all patches in this assembly

        Debug.Log($"[{p_mod.name}] Initialized successfully!");
    }

    public override void OnModUnloaded()
    {
        _harmony?.UnpatchAll(_harmony.Id);
    }
}
```

---

## Harmony Patching Fundamentals

### Patch Types

Harmony offers three main patch types:

#### 1. Prefix Patch

**When:** Runs BEFORE the original method
**Can:** Skip the original method by returning false
**Use for:** Validation, blocking actions, pre-processing

```csharp
[HarmonyPatch(typeof(Player), nameof(Player.AddWarWith))]
[HarmonyPrefix]
static bool Prefix_AddWarWith(Player __instance, Player p_player)
{
    // __instance is the Player object this method is called on
    // p_player is the first parameter

    if (p_player.Country == "Italy" && GameData.Instance.map.Date.Year < 1940)
    {
        UIManager.ShowMessage("Cannot declare war on Italy before 1940!");
        return false; // Skip the original method
    }

    return true; // Run the original method
}
```

**Key Points:**
- Can prevent the original method from running
- Has access to all parameters
- Can modify parameter values (use `ref` keyword)

#### 2. Postfix Patch

**When:** Runs AFTER the original method
**Can:** Modify return values, trigger follow-up actions
**Use for:** Adding effects, notifications, logging

```csharp
[HarmonyPatch(typeof(Player), nameof(Player.AddWarWith))]
[HarmonyPostfix]
static void Postfix_AddWarWith(Player __instance, Player p_player)
{
    // This runs after the war is declared

    if (__instance.Country == "USA" && p_player.Country == "Italy")
    {
        __instance.AddMoney(1000, false);
        UIManager.ShowMessage("Congress approves war funding: +$1000!");
    }
}
```

**Key Points:**
- Always runs (unless Prefix blocked it)
- Can modify return value using `ref` keyword
- Use `__result` parameter to access/modify return value

**Example with return value:**

```csharp
[HarmonyPatch(typeof(Unit), nameof(Unit.GetUpkeepCost))]
[HarmonyPostfix]
static void Postfix_GetUpkeepCost(Unit __instance, ref int __result)
{
    // __result is the return value from GetUpkeepCost()

    if (__instance.Type == "Infantry")
    {
        __result *= 2; // Double infantry upkeep cost
    }
}
```

#### 3. Transpiler Patch

**When:** Modifies the method's IL code directly
**Can:** Change constants, replace instructions, optimize code
**Use for:** Changing hardcoded values, advanced modifications

```csharp
[HarmonyPatch(typeof(Player), nameof(Player.GetManpowerGrowth))]
[HarmonyTranspiler]
static IEnumerable<CodeInstruction> Transpiler_GetManpowerGrowth(IEnumerable<CodeInstruction> instructions)
{
    // Replace the hardcoded 0.03f with 0.5f
    const float newValue = 0.5f;

    foreach (CodeInstruction instruction in instructions)
    {
        if (instruction.opcode == OpCodes.Ldc_R4 && (float)instruction.operand == 0.03f)
        {
            instruction.operand = newValue;
            Debug.Log($"Patched manpower growth rate to {newValue}");
        }

        yield return instruction;
    }
}
```

**Key Points:**
- Most complex patch type
- Requires understanding of IL (Intermediate Language)
- Very powerful for specific use cases
- Use sparingly - Prefix/Postfix cover most needs

### Special Patch Parameters

Harmony provides special parameter names that give you access to internals:

| Parameter Name | Type | Description |
|----------------|------|-------------|
| `__instance` | `OriginalType` | The object the method is called on (for instance methods) |
| `__result` | `ReturnType` | The return value (use `ref` to modify it) |
| `__state` | `Any` | Share data between Prefix and Postfix |
| `__originalMethod` | `MethodBase` | The original method being patched |
| `__runOriginal` | `ref bool` | Set to false in Prefix to skip original (alternative to return false) |

**Example using __state:**

```csharp
[HarmonyPatch(typeof(TurnManager), nameof(TurnManager.NextTurn))]
class Patch_NextTurn
{
    [HarmonyPrefix]
    static void Prefix(out DateTime __state)
    {
        __state = DateTime.Now; // Store current time
    }

    [HarmonyPostfix]
    static void Postfix(DateTime __state)
    {
        var elapsed = DateTime.Now - __state;
        Debug.Log($"Turn processing took {elapsed.TotalMilliseconds}ms");
    }
}
```

### Patching Multiple Methods

You can patch different methods in the same class:

```csharp
[HarmonyPatch(typeof(Player))]
class PlayerPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(Player.AddWarWith))]
    static bool Prefix_AddWarWith(Player __instance, Player p_player)
    {
        // Your code
        return true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(nameof(Player.GetManpowerGrowth))]
    static void Postfix_GetManpowerGrowth(Player __instance, ref int __result)
    {
        // Your code
    }
}
```

---

## Game API Reference

### Core Classes

#### GameData
**Singleton for main game state**

```csharp
// Access instance
GameData game = GameData.Instance;

// Properties
game.listOfPlayers      // List<Player> - All players in the game
game.map.Date.Year      // int - Current game year
game.ModDataBag         // ModDataBag - Store your custom data

// Methods
SetData(GameData p_gameData)  // Called when game/save loads
```

#### Player
**Represents a faction/country**

```csharp
Player player = TurnManager.currPlayer;

// Properties
player.Country          // string - "USA", "Nazi Germany", etc.
player.Name             // string - Player name
player.IsComputer       // bool - Is AI?
player.MoneyAmount      // int - Current money (READ THIS, NOT Money!)
player.TotalMoneySpent  // int
player.TotalMoneyEarned // int
player.TurnMoneySpent   // int
player.TurnMoneyEarned  // int

// Methods
player.AddMoney(int amount, bool sendRPC)
    // Add money (negative to remove)
    // sendRPC: true for multiplayer, false for single-player

player.RemoveMoney(int amount, bool sendRPC)
    // Remove money explicitly

player.AddWarWith(Player enemy, bool sendRPC)
    // Declare war

player.GetManpowerGrowth()
    // Returns current manpower growth rate

player.HasPolicy(string policyType)
    // Check if policy is active

player.AddUnit(Unit unit, bool sendRPC)
    // Add unit to player's army
```

#### Unit
**Represents a military unit**

```csharp
// Create a new unit
Unit unit = Utils.GenerateNewUnit("Light infantry", "USA");

// Properties
unit.Type           // string - "Infantry", "Tank", "Artillery", etc.
unit.IsReserve      // bool - Is in reserves?
unit.OwnerPlayer    // Player - Who owns this unit
unit.TurnToProduce  // int - Turns until ready

// Methods
unit.GetUpkeepCost(bool p_getReserveCost)
    // Returns upkeep cost

unit.SetDefaultProductionTime()
    // Set production time to default
```

#### TurnManager
**Manages turn order**

```csharp
// Current player
Player current = TurnManager.currPlayer;

// Methods
TurnManager.NextTurn(bool sendRPC)
    // Advance to next turn
```

#### Utils
**Utility functions**

```csharp
// Create units
Unit unit = Utils.GenerateNewUnit(string unitType, string country);

// Known unit types:
// "Infantry", "Light infantry", "Tank", "Artillery",
// "Anti-Air", "Heavy Tank", "Mechanized Infantry"
```

#### UIManager
**UI system management**

```csharp
// Show messages
UIManager.ShowMessage("Your message here!");

// Access canvas
Canvas canvas = UIManager.instance.mainCanvas;
```

### Mod Data Persistence

#### ModDataBag
**Persistent storage for mod data (saved with game)**

```csharp
// Create serializable data class
[Serializable]
public class MyModData
{
    public int someValue;
    public Dictionary<string, string> someDict = new Dictionary<string, string>();
}

// On game load
[HarmonyPatch(typeof(GameData), nameof(GameData.SetData))]
[HarmonyPrefix]
static void OnGameLoad(GameData p_gameData)
{
    const string MOD_KEY = "yourname.yourmod.data";

    if (!p_gameData.ModDataBag.TryGet(MOD_KEY, out MyModData data))
    {
        // First time - create new data
        data = new MyModData();
        p_gameData.ModDataBag.TrySet(MOD_KEY, data);
    }

    // Use your data
    Debug.Log($"My mod value: {data.someValue}");
}
```

**Important:**
- Use unique keys: `"author.modname.datakey"`
- Data classes MUST be `[Serializable]`
- Data persists in save files automatically

---

## Common Modding Patterns

### Pattern 1: Money Management

```csharp
// Get player money
Player player = TurnManager.currPlayer;
int money = player.MoneyAmount; // Property, not method!

// Check if player has enough
if (money >= 500)
{
    player.AddMoney(-500, false); // Spend $500
    UIManager.ShowMessage("Purchased for $500");
}
else
{
    UIManager.ShowMessage("Insufficient funds!");
}

// Give money
player.AddMoney(1000, false); // Add $1000
```

### Pattern 2: Adding Units

```csharp
void AddUnitsToPlayer(Player player, string unitType, int count)
{
    for (int i = 0; i < count; i++)
    {
        Unit unit = Utils.GenerateNewUnit(unitType, player.Country);
        player.AddUnit(unit, false);
        unit.IsReserve = true;
        unit.SetDefaultProductionTime();
    }

    // Refresh UI
    ReservePanelGO.instance?.RefreshDeployNotification();

    UIManager.ShowMessage($"Added {count} {unitType} to reserves!");
}

// Usage
AddUnitsToPlayer(TurnManager.currPlayer, "Light infantry", 3);
```

### Pattern 3: Turn Events

```csharp
[HarmonyPatch(typeof(TurnManager), nameof(TurnManager.NextTurn))]
class TurnEventPatch
{
    [HarmonyPostfix]
    static void OnTurnEnd()
    {
        Player current = TurnManager.currPlayer;

        // Only trigger for human players
        if (current != null && !current.IsComputer)
        {
            // Your turn end logic
            Debug.Log($"Turn ended for {current.Country}");
        }
    }
}
```

### Pattern 4: Creating UI Elements

```csharp
void CreateButton()
{
    Canvas canvas = UIManager.instance.mainCanvas;
    if (canvas == null) return;

    // Create button GameObject
    GameObject btn = new GameObject("MyButton",
        typeof(RectTransform),
        typeof(Image),
        typeof(Button));
    btn.transform.SetParent(canvas.transform, false);

    // Position and size
    RectTransform rect = btn.GetComponent<RectTransform>();
    rect.anchorMin = new Vector2(1f, 0.5f);
    rect.anchorMax = new Vector2(1f, 0.5f);
    rect.pivot = new Vector2(1f, 0.5f);
    rect.sizeDelta = new Vector2(120f, 50f);
    rect.anchoredPosition = new Vector2(-10f, 100f);

    // Style
    Image image = btn.GetComponent<Image>();
    image.color = new Color(0.2f, 0.5f, 0.3f, 0.9f);

    // Click handler
    Button button = btn.GetComponent<Button>();
    button.onClick.AddListener(() => {
        UIManager.ShowMessage("Button clicked!");
    });

    // Add text
    GameObject textObj = new GameObject("Text", typeof(RectTransform));
    textObj.transform.SetParent(btn.transform, false);

    RectTransform textRect = textObj.GetComponent<RectTransform>();
    textRect.anchorMin = Vector2.zero;
    textRect.anchorMax = Vector2.one;
    textRect.offsetMin = Vector2.zero;
    textRect.offsetMax = Vector2.zero;

    TextMeshProUGUI tmp = textObj.AddComponent<TextMeshProUGUI>();
    tmp.text = "Click Me";
    tmp.fontSize = 18f;
    tmp.alignment = TextAlignmentOptions.Center;
    tmp.color = Color.white;
}
```

### Pattern 5: Keybinds

```csharp
// Create a MonoBehaviour for input handling
public class MyModKeybinds : MonoBehaviour
{
    void Update()
    {
        // Check for key press using reflection (Input class not directly available)
        if (GetKeyDown(KeyCode.K))
        {
            UIManager.ShowMessage("K pressed!");
        }
    }

    static bool GetKeyDown(KeyCode key)
    {
        try
        {
            Type inputType = Type.GetType("UnityEngine.Input, UnityEngine.InputLegacyModule");
            if (inputType == null)
                inputType = Type.GetType("UnityEngine.Input, UnityEngine.CoreModule");

            MethodInfo method = inputType?.GetMethod("GetKeyDown", new Type[] { typeof(KeyCode) });
            return method != null && (bool)method.Invoke(null, new object[] { key });
        }
        catch
        {
            return false;
        }
    }
}

// In your mod initialization:
GameObject handler = new GameObject("MyModKeybindHandler");
handler.AddComponent<MyModKeybinds>();
GameObject.DontDestroyOnLoad(handler);
```

### Pattern 6: Reflection for Accessing Private Members

```csharp
// When you need to access private fields/methods
public static class ReflectionHelper
{
    public static T GetPrivateField<T>(object obj, string fieldName)
    {
        var field = obj.GetType().GetField(fieldName,
            BindingFlags.NonPublic | BindingFlags.Instance);
        return (T)field?.GetValue(obj);
    }

    public static void SetPrivateField(object obj, string fieldName, object value)
    {
        var field = obj.GetType().GetField(fieldName,
            BindingFlags.NonPublic | BindingFlags.Instance);
        field?.SetValue(obj, value);
    }

    public static T CallPrivateMethod<T>(object obj, string methodName, params object[] args)
    {
        var method = obj.GetType().GetMethod(methodName,
            BindingFlags.NonPublic | BindingFlags.Instance);
        return (T)method?.Invoke(obj, args);
    }
}

// Usage
int privateValue = ReflectionHelper.GetPrivateField<int>(player, "_secretValue");
```

---

## Advanced Techniques

### Multiple Patches on Same Method

```csharp
[HarmonyPatch(typeof(Player), nameof(Player.AddMoney))]
class MoneyPatch_A
{
    [HarmonyPrefix]
    static void Prefix(int amount)
    {
        Debug.Log($"Patch A: Before adding {amount}");
    }
}

[HarmonyPatch(typeof(Player), nameof(Player.AddMoney))]
class MoneyPatch_B
{
    [HarmonyPostfix]
    static void Postfix(int amount)
    {
        Debug.Log($"Patch B: After adding {amount}");
    }
}

// Both will run! Execution order:
// 1. All Prefix patches (reverse order of patching)
// 2. Original method
// 3. All Postfix patches (order of patching)
```

### Conditional Patching

```csharp
void ApplyPatches()
{
    _harmony = new Harmony("com.hexofsteel.mymod");

    // Only patch certain methods based on config
    if (ModConfig.EnableFeatureA)
    {
        _harmony.Patch(
            AccessTools.Method(typeof(Player), nameof(Player.AddMoney)),
            prefix: new HarmonyMethod(typeof(MyPatches), nameof(MyPatches.Prefix_AddMoney))
        );
    }

    if (ModConfig.EnableFeatureB)
    {
        _harmony.Patch(
            AccessTools.Method(typeof(Unit), nameof(Unit.GetUpkeepCost)),
            postfix: new HarmonyMethod(typeof(MyPatches), nameof(MyPatches.Postfix_GetUpkeepCost))
        );
    }
}
```

### AccessTools for Method Finding

```csharp
// Find methods dynamically
MethodInfo method1 = AccessTools.Method(typeof(Player), nameof(Player.AddMoney));
MethodInfo method2 = AccessTools.Method(typeof(Player), "AddMoney", new Type[] { typeof(int), typeof(bool) });

// Find properties
PropertyInfo prop = AccessTools.Property(typeof(Player), "MoneyAmount");

// Find fields
FieldInfo field = AccessTools.Field(typeof(SomeClass), "privateField");

// Find inner types
Type innerType = AccessTools.Inner(typeof(OuterClass), "InnerClass");
```

### Manual Patching

```csharp
// Instead of attributes, patch manually
void ApplyManualPatch()
{
    var harmony = new Harmony("com.hexofsteel.mymod");

    var originalMethod = AccessTools.Method(typeof(Player), nameof(Player.AddMoney));
    var prefixMethod = AccessTools.Method(typeof(MyPatches), nameof(MyPatches.MyPrefix));
    var postfixMethod = AccessTools.Method(typeof(MyPatches), nameof(MyPatches.MyPostfix));

    harmony.Patch(originalMethod,
        prefix: new HarmonyMethod(prefixMethod),
        postfix: new HarmonyMethod(postfixMethod));
}
```

---

## Debugging & Troubleshooting

### Essential Debugging Tools

#### 1. Player.log Location

```
Windows: %USERPROFILE%\AppData\LocalLow\War Frogs Studio\Hex of Steel\Player.log
macOS: ~/Library/Logs/War Frogs Studio/Hex of Steel/Player.log
Linux: ~/.config/unity3d/War Frogs Studio/Hex of Steel/Player.log
```

#### 2. Logging Best Practices

```csharp
// Use prefixes to identify your mod
Debug.Log($"[MyMod] Initialization started");
Debug.LogWarning($"[MyMod] Warning: Player is null");
Debug.LogError($"[MyMod] Error: {ex.Message}\n{ex.StackTrace}");

// Log important state
Debug.Log($"[MyMod] Player: {player.Country}, Money: {player.MoneyAmount}");

// Log method entry/exit
[HarmonyPrefix]
static bool Prefix(Player __instance)
{
    Debug.Log($"[MyMod] Entering AddWarWith for {__instance.Country}");
    return true;
}
```

#### 3. Null Checking

```csharp
// ALWAYS null-check!
if (GameData.Instance == null)
{
    Debug.LogWarning("[MyMod] GameData.Instance is null!");
    return;
}

Player player = TurnManager.currPlayer;
if (player == null)
{
    Debug.LogWarning("[MyMod] TurnManager.currPlayer is null!");
    return;
}

// Use null-conditional operators
ReservePanelGO.instance?.RefreshDeployNotification();
```

### Common Issues and Solutions

#### Issue: Patch Not Running

**Symptoms:** Your patch code never executes

**Solutions:**
1. Check method name is correct (use `nameof()`)
2. Verify method signature matches
3. Check if method is public and accessible
4. Look for errors in Player.log during patch application
5. Ensure class is static for Harmony patches

```csharp
// ❌ Wrong - instance class
public class MyPatch { }

// ✅ Correct - static class
public static class MyPatch { }

// ✅ Also correct - inner static class
[HarmonyPatch(typeof(Player))]
class PlayerPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(Player.AddMoney))]
    static void Prefix() { }
}
```

#### Issue: ModDataBag Not Saving

**Symptoms:** Your data resets on game load

**Solutions:**
1. Ensure class is `[Serializable]`
2. Use primitive types or serializable collections
3. Initialize data in `GameData.SetData` patch

```csharp
// ✅ Correct
[Serializable]
public class MyData
{
    public int value;
    public List<string> items = new List<string>();
}

// ❌ Wrong - not serializable
public class MyData
{
    public Action callback; // Cannot serialize delegates
    public GameObject obj;  // Cannot serialize Unity objects
}
```

#### Issue: UI Not Showing

**Symptoms:** Created UI elements don't appear

**Solutions:**
1. Check canvas exists
2. Verify RectTransform setup
3. Check if element is behind other UI
4. Ensure proper parent-child hierarchy

```csharp
// Debug UI creation
GameObject panel = new GameObject("MyPanel", typeof(RectTransform), typeof(Image));
panel.transform.SetParent(canvas.transform, false);

Debug.Log($"[MyMod] Panel created: {panel.name}");
Debug.Log($"[MyMod] Panel parent: {panel.transform.parent?.name}");
Debug.Log($"[MyMod] Panel active: {panel.activeSelf}");

RectTransform rect = panel.GetComponent<RectTransform>();
Debug.Log($"[MyMod] Panel position: {rect.anchoredPosition}");
Debug.Log($"[MyMod] Panel size: {rect.sizeDelta}");
```

#### Issue: Money Detection Failing

**Symptoms:** Always returns 0 for player money

**Solution:** Use `MoneyAmount` property, NOT `Money`

```csharp
// ❌ Wrong
int money = player.Money; // Doesn't exist!

// ✅ Correct
int money = player.MoneyAmount;
```

### API Discovery Helper

Use this to discover available APIs at runtime:

```csharp
void DumpTypeAPI(Type type)
{
    Debug.Log($"=== {type.Name} API ===");

    // Methods
    var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
    foreach (var m in methods.OrderBy(x => x.Name))
    {
        var parameters = string.Join(", ", m.GetParameters().Select(p => p.ParameterType.Name));
        Debug.Log($"  {m.ReturnType.Name} {m.Name}({parameters})");
    }

    // Properties
    var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
    foreach (var p in props.OrderBy(x => x.Name))
    {
        Debug.Log($"  {p.PropertyType.Name} {p.Name}");
    }

    // Fields
    var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
    foreach (var f in fields.OrderBy(x => x.Name))
    {
        Debug.Log($"  {f.FieldType.Name} {f.Name}");
    }
}

// Usage
DumpTypeAPI(typeof(Player));
DumpTypeAPI(typeof(Unit));
DumpTypeAPI(typeof(TurnManager));
```

---

## Complete Examples

### Example 1: Custom Resource System

```csharp
// Define persistent data
[Serializable]
public class ResourceData
{
    public Dictionary<string, int> playerResources = new Dictionary<string, int>();
}

[HarmonyPatch(typeof(GameData))]
class ResourceSystemPatch
{
    const string MOD_KEY = "example.resources.data";
    static ResourceData _data;

    [HarmonyPrefix]
    [HarmonyPatch(nameof(GameData.SetData))]
    static void OnGameLoad(GameData p_gameData)
    {
        if (!p_gameData.ModDataBag.TryGet(MOD_KEY, out _data))
        {
            _data = new ResourceData();
            p_gameData.ModDataBag.TrySet(MOD_KEY, _data);
        }
    }

    public static void AddResource(Player player, int amount)
    {
        if (!_data.playerResources.ContainsKey(player.Name))
            _data.playerResources[player.Name] = 0;

        _data.playerResources[player.Name] += amount;
        UIManager.ShowMessage($"Gained {amount} resources!");
    }

    public static int GetResource(Player player)
    {
        return _data.playerResources.TryGetValue(player.Name, out int amount) ? amount : 0;
    }
}

// Use it
[HarmonyPatch(typeof(TurnManager), nameof(TurnManager.NextTurn))]
class TurnResourceGain
{
    [HarmonyPostfix]
    static void Postfix()
    {
        Player player = TurnManager.currPlayer;
        if (player != null && !player.IsComputer)
        {
            ResourceSystemPatch.AddResource(player, 10);
        }
    }
}
```

### Example 2: Unit Veterancy System

```csharp
[Serializable]
public class VeterancyData
{
    public Dictionary<string, int> unitExperience = new Dictionary<string, int>();
}

[HarmonyPatch(typeof(UnitGO))]
class VeterancyPatch
{
    const string MOD_KEY = "example.veterancy.data";
    static VeterancyData _data;

    // Initialize
    [HarmonyPatch(typeof(GameData), nameof(GameData.SetData))]
    [HarmonyPrefix]
    static void InitData(GameData p_gameData)
    {
        if (!p_gameData.ModDataBag.TryGet(MOD_KEY, out _data))
        {
            _data = new VeterancyData();
            p_gameData.ModDataBag.TrySet(MOD_KEY, _data);
        }
    }

    // Track combat
    [HarmonyPatch(nameof(UnitGO.AttackUnit))]
    [HarmonyPostfix]
    static void OnAttack(UnitGO __instance, UnitGO target)
    {
        // Get unique unit ID (you'd need to implement this)
        string unitId = GetUnitID(__instance);

        if (!_data.unitExperience.ContainsKey(unitId))
            _data.unitExperience[unitId] = 0;

        _data.unitExperience[unitId] += 10; // XP per attack

        int xp = _data.unitExperience[unitId];
        if (xp >= 100)
        {
            UIManager.ShowMessage($"Unit gained veteran status!");
        }
    }

    // Apply veteran bonuses
    [HarmonyPatch(typeof(Unit), nameof(Unit.GetUpkeepCost))]
    [HarmonyPostfix]
    static void VeteranBonus(Unit __instance, ref int __result)
    {
        string unitId = GetUnitID(__instance);

        if (_data.unitExperience.TryGetValue(unitId, out int xp) && xp >= 100)
        {
            __result = (int)(__result * 0.8f); // 20% discount for veterans
        }
    }

    static string GetUnitID(object unit)
    {
        // Implement unique ID system
        return unit.GetHashCode().ToString();
    }
}
```

### Example 3: Event System

```csharp
public enum EventType
{
    EconomicBoom,
    Recession,
    ManpowerSurge,
    Drought
}

[Serializable]
public class GameEvent
{
    public EventType type;
    public int turnsRemaining;
    public string description;
}

[Serializable]
public class EventData
{
    public List<GameEvent> activeEvents = new List<GameEvent>();
    public int turnsSinceLastEvent = 0;
}

[HarmonyPatch]
class EventSystem
{
    const string MOD_KEY = "example.events.data";
    static EventData _data;

    [HarmonyPatch(typeof(GameData), nameof(GameData.SetData))]
    [HarmonyPrefix]
    static void InitData(GameData p_gameData)
    {
        if (!p_gameData.ModDataBag.TryGet(MOD_KEY, out _data))
        {
            _data = new EventData();
            p_gameData.ModDataBag.TrySet(MOD_KEY, _data);
        }
    }

    [HarmonyPatch(typeof(TurnManager), nameof(TurnManager.NextTurn))]
    [HarmonyPostfix]
    static void OnTurnEnd()
    {
        _data.turnsSinceLastEvent++;

        // Random event chance
        if (_data.turnsSinceLastEvent > 5 && UnityEngine.Random.value < 0.2f)
        {
            TriggerRandomEvent();
            _data.turnsSinceLastEvent = 0;
        }

        // Process active events
        ProcessEvents();
    }

    static void TriggerRandomEvent()
    {
        EventType type = (EventType)UnityEngine.Random.Range(0, 4);

        GameEvent evt = new GameEvent
        {
            type = type,
            turnsRemaining = 3,
            description = GetEventDescription(type)
        };

        _data.activeEvents.Add(evt);
        UIManager.ShowMessage($"EVENT: {evt.description}");
    }

    static void ProcessEvents()
    {
        for (int i = _data.activeEvents.Count - 1; i >= 0; i--)
        {
            var evt = _data.activeEvents[i];
            evt.turnsRemaining--;

            // Apply effects
            ApplyEventEffect(evt);

            if (evt.turnsRemaining <= 0)
            {
                _data.activeEvents.RemoveAt(i);
                UIManager.ShowMessage($"Event ended: {evt.description}");
            }
        }
    }

    static void ApplyEventEffect(GameEvent evt)
    {
        Player player = TurnManager.currPlayer;
        if (player == null || player.IsComputer) return;

        switch (evt.type)
        {
            case EventType.EconomicBoom:
                player.AddMoney(200, false);
                break;
            case EventType.Recession:
                player.AddMoney(-100, false);
                break;
            // Add more effects...
        }
    }

    static string GetEventDescription(EventType type)
    {
        switch (type)
        {
            case EventType.EconomicBoom: return "Economic Boom (+$200/turn)";
            case EventType.Recession: return "Recession (-$100/turn)";
            default: return "Unknown Event";
        }
    }
}
```

---

## Best Practices

### 1. Unique Naming

```csharp
// ✅ Good - unique prefix
const string MOD_KEY = "robbins.divisionenablers.data";
Harmony harmony = new Harmony("com.hexofsteel.robbins.divisionenablers");

// ❌ Bad - generic names
const string MOD_KEY = "data";
Harmony harmony = new Harmony("mymod");
```

### 2. Null Safety

```csharp
// ✅ Always check for null
if (GameData.Instance == null) return;
Player player = TurnManager.currPlayer;
if (player == null) return;

// ✅ Use null-conditional
UIManager.instance?.ShowMessage("Safe!");
ReservePanelGO.instance?.RefreshDeployNotification();
```

### 3. RPC Parameter

```csharp
// Single-player mod
player.AddMoney(100, false);  // ✅ Use false

// Multiplayer-compatible mod
player.AddMoney(100, true);   // ✅ Use true to sync
```

### 4. Serialization

```csharp
// ✅ Good - serializable
[Serializable]
public class ModData
{
    public int value;
    public List<string> items;
    public Dictionary<string, int> dict;
}

// ❌ Bad - not serializable
public class ModData
{
    public Action callback;     // Delegates don't serialize
    public GameObject obj;      // Unity objects don't serialize
    public static int value;    // Static fields don't serialize
}
```

### 5. Performance

```csharp
// ❌ Bad - expensive operation in frequently-called patch
[HarmonyPatch(typeof(Unit), nameof(Unit.GetUpkeepCost))]
[HarmonyPostfix]
static void Postfix()
{
    // This runs for EVERY unit EVERY time upkeep is calculated!
    var allUnits = GameObject.FindObjectsOfType<UnitGO>(); // EXPENSIVE!
}

// ✅ Good - cache expensive operations
static List<UnitGO> _cachedUnits;
static int _lastCacheUpdate;

static void UpdateCache()
{
    if (TurnManager.currentTurn != _lastCacheUpdate)
    {
        _cachedUnits = GameObject.FindObjectsOfType<UnitGO>().ToList();
        _lastCacheUpdate = TurnManager.currentTurn;
    }
}
```

### 6. Error Handling

```csharp
// ✅ Good - wrapped in try-catch
[HarmonyPostfix]
static void Postfix(Player __instance)
{
    try
    {
        // Your code
    }
    catch (Exception ex)
    {
        Debug.LogError($"[MyMod] Error: {ex.Message}\n{ex.StackTrace}");
    }
}
```

### 7. Debug Logging

```csharp
// ✅ Good - informative logs
Debug.Log($"[MyMod] Initializing for {player.Country}");
Debug.Log($"[MyMod] Money: {player.MoneyAmount}, Units: {units.Count}");

// ❌ Bad - vague logs
Debug.Log("Started");
Debug.Log("Done");
```

---

## API Explorer

### Using the API Explorer

The `APIExplorer.cs` file included in your mod provides tools to discover ALL available game APIs at runtime.

#### Basic Usage

```csharp
// In your mod initialization
APIExplorer.DumpAllGameAPIs();  // Dumps everything to Player.log
```

#### Specific Class Dump

```csharp
// Dump specific classes
APIExplorer.DumpClassAPI(typeof(Player));
APIExplorer.DumpClassAPI(typeof(Unit));
APIExplorer.DumpClassAPI(typeof(TurnManager));
```

#### Search for Classes

```csharp
// Find all classes containing "combat"
APIExplorer.FindClassesContaining("combat");

// Find all classes containing "tile"
APIExplorer.FindClassesContaining("tile");
```

#### List All Classes

```csharp
// WARNING: Very verbose! Lists EVERYTHING
APIExplorer.ListAllClasses();
```

### Reading API Dump Output

The output in Player.log will look like:

```
========================================
API DUMP: Player
========================================

--- PUBLIC METHODS (Player) ---
  Void AddMoney(Int32 amount, Boolean sendRPC)
  Void AddWarWith(Player p_player, Boolean p_sendRPC)
  Int32 GetManpowerGrowth()
  Boolean HasPolicy(String policyType)

--- PUBLIC PROPERTIES (Player) ---
  String Country { get; set; }
  Boolean IsComputer { get; set; }
  Int32 MoneyAmount { get; set; }

--- PUBLIC FIELDS (Player) ---
  String Name
```

Use this information to:
- Discover available methods
- Find correct method signatures
- See property names
- Identify fields you can access

---

## Additional Resources

### Official Links

- **Hex of Steel Discord:** https://discord.gg/Tn63mrwJyH
- **Harmony Documentation:** https://harmony.pardeike.net/
- **.NET 8 SDK:** https://dotnet.microsoft.com/download/dotnet/8.0

### Useful Tools

- **dnSpy** - .NET assembly browser/decompiler
- **ILSpy** - Alternative assembly browser
- **Visual Studio Code** - Lightweight IDE
- **Rider** - Professional C# IDE (paid)

### Tips from the Community

1. **Test in Single-Player First** - Multiplayer adds complexity
2. **Use Version Control** - Git your mod folder
3. **Keep Backups** - Save files before testing
4. **Read the Logs** - Player.log is your friend
5. **Ask for Help** - Discord community is helpful
6. **Share Your Mods** - Community benefits from sharing

---

## Conclusion

You now have a complete reference for modding Hex of Steel with Harmony! Key takeaways:

- ✅ Use **Prefix** to block/modify before
- ✅ Use **Postfix** to add effects after
- ✅ Use **Transpiler** for IL code changes (advanced)
- ✅ Always null-check `GameData.Instance` and `TurnManager.currPlayer`
- ✅ Use `MoneyAmount` property for money
- ✅ Store data in `ModDataBag` for persistence
- ✅ Log everything during development
- ✅ Use `APIExplorer` to discover available APIs

**Happy Modding!** 🎮

---

*This manual is maintained by the community. Contributions welcome!*
