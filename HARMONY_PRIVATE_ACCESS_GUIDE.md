# Harmony Private Member Access Guide

## Overview

**One of Harmony's most powerful features:** You can access and modify **ANY** private method, field, or property in the game, even if it's marked as `private` or `internal`!

This guide shows you how to:
1. Discover private members using the API Explorer
2. Patch private methods
3. Read/write private fields
4. Call private methods
5. Access private properties

---

## Why This Matters

Game developers often make their internal logic `private` to protect it from external access. But with Harmony's reflection capabilities, you can:

- **Patch private methods** that contain critical game logic
- **Read private fields** to understand internal state
- **Modify private fields** to change game behavior
- **Call private methods** to trigger internal functionality

**Everything is accessible with Harmony!**

---

## Generating Complete API Documentation

### Step 1: Choose Your Documentation Level

Edit [ExampleMod.cs](Scripts/ExampleMod.cs) and uncomment **ONE** of these lines:

```csharp
// Option 1: Public members only (smaller file, basics only)
APIExplorerToFile.DumpAllGameAPIsToFile();

// Option 2: Core classes with private members (recommended)
APIExplorerComplete.DumpCoreClassesWithPrivate();

// Option 3: EVERYTHING with private members (HUGE file, complete reference)
APIExplorerComplete.DumpCompleteAPIToFile();
```

### Step 2: Build and Run

```bash
dotnet build
# Copy DLL to your mods folder
# Run the game and start a scenario
```

### Step 3: Find Your Documentation

The generated file will appear in your game directory:
- `HexOfSteel_API_COMPLETE_WITH_PRIVATE.md` (Option 3)
- `HexOfSteel_API_Core_With_Private.md` (Option 2)

---

## Patching Private Methods

### Basic Example

Suppose you discover this private method in the API documentation:

```markdown
### Private Methods
- `private void CalculateCombatDamage(Unit attacker, Unit defender)`
```

You can patch it just like a public method:

```csharp
using HarmonyLib;
using UnityEngine;

[HarmonyPatch(typeof(Combat), "CalculateCombatDamage")]
class Patch_Combat_CalculateCombatDamage
{
    static bool Prefix(Unit attacker, Unit defender)
    {
        Debug.Log($"Combat calculation: {attacker.name} vs {defender.name}");

        // Return false to skip the original method
        // Return true to run the original method
        return true;
    }

    static void Postfix(Unit attacker, Unit defender)
    {
        Debug.Log($"Combat calculation complete!");
    }
}
```

### With Parameters and Return Values

```csharp
[HarmonyPatch(typeof(GameData), "InternalCalculateScore")]
class Patch_GameData_InternalCalculateScore
{
    // Access original method's return value
    static void Postfix(Player player, ref int __result)
    {
        Debug.Log($"Original score: {__result}");

        // Modify the return value
        __result *= 2; // Double all scores!

        Debug.Log($"Modified score: {__result}");
    }
}
```

---

## Accessing Private Fields

### Using Traverse (Recommended)

Harmony's `Traverse` class makes private field access easy:

```csharp
using HarmonyLib;

// Reading a private field
var gameData = GameData.GetInstance();
var privateValue = Traverse.Create(gameData)
    .Field("privateFieldName")
    .GetValue<int>();

Debug.Log($"Private field value: {privateValue}");

// Writing to a private field
Traverse.Create(gameData)
    .Field("privateFieldName")
    .SetValue(42);

Debug.Log("Private field updated!");
```

### Using AccessTools

For when you need the `FieldInfo` directly:

```csharp
using HarmonyLib;
using System.Reflection;

var instance = GetYourInstance();
var fieldInfo = AccessTools.Field(typeof(Player), "privateGoldAmount");

// Read
var goldAmount = (int)fieldInfo.GetValue(instance);
Debug.Log($"Player has {goldAmount} gold (private field)");

// Write
fieldInfo.SetValue(instance, 9999);
Debug.Log("Player gold set to 9999!");
```

### Real-World Example

```csharp
[HarmonyPatch(typeof(Unit), "Update")]
class Patch_Unit_Update
{
    static void Postfix(Unit __instance)
    {
        // Access private field "_currentHealth"
        var health = Traverse.Create(__instance)
            .Field("_currentHealth")
            .GetValue<float>();

        if (health < 10)
        {
            Debug.Log($"Unit {__instance.name} is low on health: {health}");
        }
    }
}
```

---

## Calling Private Methods

### Using Traverse

```csharp
var player = GetPlayer();

// Call a private method with no parameters
Traverse.Create(player)
    .Method("RecalculateIncome")
    .GetValue(); // Actually invokes the method

// Call a private method with parameters
Traverse.Create(player)
    .Method("AddHiddenBonus", new object[] { 100, "gold" })
    .GetValue();
```

### Using AccessTools

```csharp
var player = GetPlayer();
var methodInfo = AccessTools.Method(typeof(Player), "RecalculateIncome");

// Invoke with no parameters
methodInfo.Invoke(player, null);

// Invoke with parameters
var methodWithParams = AccessTools.Method(typeof(Player), "AddHiddenBonus");
methodWithParams.Invoke(player, new object[] { 100, "gold" });

// Get return value
var calculateMethod = AccessTools.Method(typeof(Player), "CalculatePrivateScore");
int score = (int)calculateMethod.Invoke(player, null);
Debug.Log($"Private score calculation result: {score}");
```

---

## Accessing Private Properties

### Using Traverse

```csharp
var unit = GetUnit();

// Read a private property
var isMoving = Traverse.Create(unit)
    .Property("IsInternallyMoving")
    .GetValue<bool>();

Debug.Log($"Unit is moving (private): {isMoving}");

// Write to a private property (if it has a setter)
Traverse.Create(unit)
    .Property("IsInternallyMoving")
    .SetValue(false);
```

### Using AccessTools

```csharp
var propertyInfo = AccessTools.Property(typeof(Unit), "IsInternallyMoving");

// Read
var value = propertyInfo.GetValue(unit);

// Write
propertyInfo.SetValue(unit, false);
```

---

## Advanced Techniques

### Accessing Nested Private Classes

If you find a private nested class in the documentation:

```markdown
### Nested Types
- `private class InternalData`
```

You can access it:

```csharp
// Get the nested type
var assembly = Assembly.Load("Assembly-CSharp");
var parentType = assembly.GetType("ParentClassName");
var nestedType = parentType.GetNestedType("InternalData", BindingFlags.NonPublic);

// Create an instance
var instance = Activator.CreateInstance(nestedType);

// Access its members
var field = AccessTools.Field(nestedType, "someField");
field.SetValue(instance, "new value");
```

### Patching Private Static Methods

```csharp
[HarmonyPatch(typeof(Utils), "PrivateStaticHelper")]
class Patch_Utils_PrivateStaticHelper
{
    static bool Prefix()
    {
        Debug.Log("Private static method called!");
        return true;
    }
}
```

### Accessing Private Collections

```csharp
// Access a private List<T>
var privateList = Traverse.Create(gameData)
    .Field("_internalPlayerList")
    .GetValue<System.Collections.Generic.List<Player>>();

foreach (var player in privateList)
{
    Debug.Log($"Player from private list: {player.name}");
}

// Modify the list
privateList.Add(newPlayer);
```

---

## Complete Working Example

Here's a full example showing multiple techniques:

```csharp
using HarmonyLib;
using UnityEngine;

// 1. Patch a private method
[HarmonyPatch(typeof(Player), "InternalUpdateResources")]
class Patch_Player_InternalUpdateResources
{
    static void Prefix(Player __instance)
    {
        Debug.Log($"[PATCH] Player {__instance.name} is updating resources (private method)");

        // 2. Read a private field
        var goldReserve = Traverse.Create(__instance)
            .Field("_hiddenGoldReserve")
            .GetValue<int>();

        Debug.Log($"Hidden gold reserve: {goldReserve}");

        // 3. Modify a private field
        if (goldReserve < 100)
        {
            Traverse.Create(__instance)
                .Field("_hiddenGoldReserve")
                .SetValue(100);
            Debug.Log("Boosted player's hidden gold reserve to 100");
        }

        // 4. Call a private method
        Traverse.Create(__instance)
            .Method("RecalculateBonuses")
            .GetValue();

        Debug.Log("Called private RecalculateBonuses method");

        // 5. Access a private property
        var isAIControlled = Traverse.Create(__instance)
            .Property("IsAIControlled")
            .GetValue<bool>();

        if (isAIControlled)
        {
            Debug.Log("This is an AI player (private property)");
        }
    }
}
```

---

## Important Notes

### ⚠️ Method Signatures Matter

When patching methods, make sure you have the **exact** signature:

```csharp
// If the method is:
// private void DoSomething(int amount, string type)

// Your patch must match:
[HarmonyPatch(typeof(MyClass), "DoSomething", new Type[] { typeof(int), typeof(string) })]
```

### ⚠️ Overloaded Methods

If a class has multiple methods with the same name (overloads), specify which one:

```csharp
// Method 1: DoSomething(int x)
// Method 2: DoSomething(int x, string y)

[HarmonyPatch(typeof(MyClass), "DoSomething", new Type[] { typeof(int) })]
class Patch1 { }

[HarmonyPatch(typeof(MyClass), "DoSomething", new Type[] { typeof(int), typeof(string) })]
class Patch2 { }
```

### ⚠️ Performance Considerations

Accessing private members via reflection is slightly slower than normal field access. For performance-critical code:

1. Cache the `FieldInfo` or `MethodInfo`
2. Use delegates for repeated method calls
3. Consider patching instead of repeated reflection

```csharp
// Cache the FieldInfo
private static FieldInfo _cachedField = AccessTools.Field(typeof(Player), "privateField");

// Use it repeatedly without reflection overhead
var value = (int)_cachedField.GetValue(player);
```

---

## Debugging Tips

### Log Everything

When exploring private members:

```csharp
static void Postfix(MyClass __instance)
{
    // Log all private fields
    var type = typeof(MyClass);
    var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

    foreach (var field in fields)
    {
        var value = field.GetValue(__instance);
        Debug.Log($"Private field {field.Name} = {value}");
    }
}
```

### Use the Generated Documentation

Always refer to your generated API documentation to see:
- Available private methods
- Parameter types
- Return types
- Whether methods are static or instance

---

## Summary

| Task | Method | Example |
|------|--------|---------|
| Patch private method | `[HarmonyPatch]` | `[HarmonyPatch(typeof(Class), "PrivateMethod")]` |
| Read private field | `Traverse` | `Traverse.Create(obj).Field("name").GetValue<T>()` |
| Write private field | `Traverse` | `Traverse.Create(obj).Field("name").SetValue(val)` |
| Call private method | `Traverse` | `Traverse.Create(obj).Method("name").GetValue()` |
| Get FieldInfo | `AccessTools` | `AccessTools.Field(typeof(Class), "field")` |
| Get MethodInfo | `AccessTools` | `AccessTools.Method(typeof(Class), "method")` |

---

## Next Steps

1. **Generate your complete API documentation** with private members
2. **Study the private methods** in classes you want to mod
3. **Experiment with Traverse** to access private fields
4. **Create patches** for private methods
5. **Share your findings** with the modding community!

---

## Additional Resources

- [Harmony Documentation](https://harmony.pardeike.net/)
- [Harmony Traverse](https://harmony.pardeike.net/articles/utilities.html#traverse)
- [Harmony AccessTools](https://harmony.pardeike.net/articles/utilities.html#accesstools)
- [C# Reflection Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection)

---

**Happy Modding! 🔧**

*With Harmony, nothing is truly private!*
