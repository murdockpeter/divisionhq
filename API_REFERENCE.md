# Hex of Steel - Modding API Reference

This document lists all the exposed game classes and methods available for modding via Harmony.

## Core Game Classes

### GameData
**Description:** Main game state manager
**Access:** `GameData.Instance`

**Properties:**
- `map.Date.Year` - Current game year
- `ModDataBag` - Storage for custom mod data
- `listOfPlayers` - List of all players in the game

**Methods:**
- `SetData(GameData p_gameData)` - Called when game/save loads

### Player
**Description:** Represents a player/faction in the game

**Properties:**
- `Country` - String name of the country (e.g., "USA", "Nazi Germany")
- `Name` - Player name
- `IsComputer` - Boolean, true if AI player
- `MoneyAmount` - Int32, current money (USE THIS, not "Money")
- `TotalMoneySpent` - Int32
- `TotalMoneyEarned` - Int32
- `TurnMoneySpent` - Int32
- `TurnMoneyEarned` - Int32

**Methods:**
- `AddMoney(int amount, bool sendRPC)` - Add/remove money (negative to remove)
- `RemoveMoney(int amount, bool sendRPC)` - Remove money
- `AddWarWith(Player p_player, bool p_sendRPC)` - Declare war on another player
- `GetManpowerGrowth()` - Returns int, manpower growth rate
- `HasPolicy(string policyType)` - Check if player has a policy active
- `AddUnit(Unit unit, bool sendRPC)` - Add a unit to player's army

### Unit
**Description:** Represents a military unit

**Properties:**
- `Type` - String, unit type (e.g., "Infantry", "Light infantry", "Tank")
- `IsReserve` - Boolean, if unit is in reserves
- `OwnerPlayer` - The Player who owns this unit
- `TurnToProduce` - Int, turns until unit is ready

**Methods:**
- `GetUpkeepCost(bool p_getReserveCost)` - Returns int, upkeep cost
- `SetDefaultProductionTime()` - Sets production time to default for unit type

### UnitGO
**Description:** Unit GameObject (visual/interactive representation)

**Methods:**
- `Attack()` - Execute attack
- `AttackUnit(UnitGO target)` - Attack a specific unit
- `TryCaptureTile()` - Attempt to capture current tile

### TurnManager
**Description:** Manages turn order and current player

**Properties:**
- `currPlayer` - The current Player whose turn it is

**Methods:**
- `NextTurn(bool p_sendRPC)` - Advance to next player's turn

### Utils
**Description:** Utility functions

**Methods:**
- `GenerateNewUnit(string unitType, string country)` - Creates a new Unit
  - Unit types: "Infantry", "Light infantry", "Tank", "Artillery", etc.

### UIManager
**Description:** UI management and messaging

**Properties:**
- `instance` - Singleton instance
- `mainCanvas` - Main Canvas for UI elements

**Methods:**
- `ShowMessage(string message)` - Display message to player

### Policies
**Description:** Policy system management

**Properties:**
- `Categories` - List of policy categories

**Methods:**
- `AddPolicy(Policy policy)` - Add a new policy to the game
- `GeneratePolicies()` - Called when generating available policies
- `GetPolicyIcon(string policyType)` - Get icon sprite for policy

### LocalizationManager
**Description:** Handles text translation

**Methods:**
- `Translate(string key)` - Get translated text for current language
- `GetLocalizedCountry(string countryKey)` - Get localized country name

### ReservePanelGO
**Description:** Reserve units panel

**Properties:**
- `instance` - Singleton instance

**Methods:**
- `RefreshDeployNotification()` - Update reserve panel UI

### PlayerSettings
**Description:** Game settings and preferences

**Methods:**
- `GetInstance()` - Get singleton instance

**Properties:**
- `DifficultyLevel` - Int (1-4), current difficulty
- `Language` - GameLanguages enum (EN, DE, FR, ES, RU, CNS)

## Modding Support Classes

### ModDataBag
**Description:** Storage system for custom mod data (persists in saves)

**Methods:**
- `TryGet<T>(string key, out T data)` - Retrieve stored data
- `TrySet<T>(string key, T data)` - Store data (will be saved with game)

**Usage:**
```csharp
GameData.Instance.ModDataBag.TrySet("mymod.key", myData);
GameData.Instance.ModDataBag.TryGet("mymod.key", out MyData data);
```

## Common Patterns

### 1. Accessing Current Player
```csharp
Player currentPlayer = TurnManager.currPlayer;
if (currentPlayer != null && !currentPlayer.IsComputer)
{
    // Do something with human player
}
```

### 2. Getting Player Money
```csharp
int money = currentPlayer.MoneyAmount; // Property, not method!
currentPlayer.AddMoney(100, false); // Add money
currentPlayer.AddMoney(-50, false); // Remove money
```

### 3. Adding Units
```csharp
Unit unit = Utils.GenerateNewUnit("Light infantry", player.Country);
player.AddUnit(unit, false);
unit.IsReserve = true;
unit.SetDefaultProductionTime();
ReservePanelGO.instance?.RefreshDeployNotification();
```

### 4. Storing Persistent Data
```csharp
// On game load
[HarmonyPatch(typeof(GameData), nameof(GameData.SetData))]
[HarmonyPrefix]
static void Patch_SetData(GameData p_gameData)
{
    if (!p_gameData.ModDataBag.TryGet("mymod.data", out MyModData data))
    {
        data = new MyModData();
        p_gameData.ModDataBag.TrySet("mymod.data", data);
    }
}
```

### 5. Showing Messages
```csharp
UIManager.ShowMessage("Your custom message here!");
```

### 6. Turn Events
```csharp
[HarmonyPatch(typeof(TurnManager), nameof(TurnManager.NextTurn))]
[HarmonyPostfix]
static void OnTurnEnd()
{
    // Called after each turn ends
}
```

## What You Can Do

### ✅ Confirmed Working
- Modify player money
- Add/remove units
- Create custom UI panels
- Store persistent data in saves
- Patch any public method
- Declare wars between players
- Modify unit stats/costs
- Add custom policies
- Show messages to players
- Track custom game state
- Modify manpower growth
- Add custom localization

### ❓ Unknown / Need to Explore
- Direct unit combat damage
- Fog of war manipulation
- Tile/province data access
- Direct unit HP/strength modification
- AI behavior modification (AI class methods are mostly private)
- Diplomacy beyond war declarations
- Custom unit types (may need to patch unit generation)

## Finding More Methods

To discover what's available on any class, use reflection:

```csharp
Type playerType = typeof(Player);
var methods = playerType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
foreach (var method in methods)
{
    Debug.Log($"Method: {method.Name} returns {method.ReturnType.Name}");
}

var properties = playerType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
foreach (var prop in properties)
{
    Debug.Log($"Property: {prop.Name} type {prop.PropertyType.Name}");
}
```

## RPC Parameter (sendRPC / p_sendRPC)

Many methods have a `bool sendRPC` or `bool p_sendRPC` parameter:
- `true` = Send this action to multiplayer clients (use for player actions)
- `false` = Local only (use for single-player or when you're handling sync yourself)

For single-player mods, generally use `false`.

## Best Practices

1. **Always null-check:** `GameData.Instance`, `TurnManager.currPlayer`, etc. can be null
2. **Use MoneyAmount property:** Not `Money` or `GetMoney()`
3. **Log everything during development:** Use `Debug.Log()` liberally
4. **Mark classes [Serializable]:** For data stored in ModDataBag
5. **Use unique mod keys:** Format: `"author.modname.datakey"`
6. **Test in single-player first:** Multiplayer adds complexity

## Need More?

To explore what's available on any class at runtime, add this to your mod initialization:

```csharp
Type type = typeof(Unit); // Or any other class
Debug.Log($"=== {type.Name} API ===");

var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
foreach (var m in methods)
    Debug.Log($"Method: {m.Name}({string.Join(", ", m.GetParameters().Select(p => p.ParameterType.Name))})");

var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
foreach (var p in props)
    Debug.Log($"Property: {p.Name} : {p.PropertyType.Name}");

var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
foreach (var f in fields)
    Debug.Log($"Field: {f.Name} : {f.FieldType.Name}");
```

This will dump the complete API to the Player.log file!
