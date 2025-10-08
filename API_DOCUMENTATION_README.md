# API Documentation Generator - Quick Reference

## 📚 Available Documentation Options

Your mod now has **4 different API documentation generators** to choose from:

| Generator | What It Documents | File Generated | Size | Recommended For |
|-----------|------------------|----------------|------|----------------|
| `APIExplorerToFile.DumpAllGameAPIsToFile()` | All **public** classes & members | `HexOfSteel_API_Complete.md` | Large | Public API reference |
| `APIExplorerToFile.DumpCoreClassesOnly()` | Core **public** classes only | `HexOfSteel_API_Core.md` | Small | Beginners, quick reference |
| `APIExplorerComplete.DumpCompleteAPIToFile()` | All classes with **public + private** | `HexOfSteel_API_COMPLETE_WITH_PRIVATE.md` | Very Large | Advanced modding |
| `APIExplorerComplete.DumpCoreClassesWithPrivate()` | Core classes with **public + private** | `HexOfSteel_API_Core_With_Private.md` | Medium | **Recommended start** |

---

## 🚀 Quick Start (3 Steps)

### Step 1: Choose Your Generator

Edit [Scripts/ExampleMod.cs](Scripts/ExampleMod.cs) (around line 85) and **uncomment ONE line**:

```csharp
// For beginners - core classes only (public members):
// APIExplorerToFile.DumpCoreClassesOnly();

// For advanced - core classes with private members (RECOMMENDED):
APIExplorerComplete.DumpCoreClassesWithPrivate();

// For complete reference - everything with private members:
// APIExplorerComplete.DumpCompleteAPIToFile();
```

### Step 2: Build & Install

```bash
dotnet build
```

The DLL is already copied to your mods folder at:
```
C:\Users\Peter G. Robbins\AppData\LocalLow\War Frogs Studio\Hex of Steel\MODS\Division Enablers\Libraries\
```

### Step 3: Run the Game

1. Launch Hex Of Steel
2. Start or load any scenario
3. The documentation will generate automatically!

**File location:** `D:\SteamLibrary\steamapps\common\Hex of Steel\`

---

## 📂 Finding Your Documentation

### Option A: Use the Batch Script

Double-click: [CheckForAPIDoc.bat](CheckForAPIDoc.bat)

This will:
- Search for all generated API documentation files
- Automatically open any found files
- Show recent Player.log entries

### Option B: Manual Check

Go to: `D:\SteamLibrary\steamapps\common\Hex of Steel\`

Look for files:
- `HexOfSteel_API_Complete.md`
- `HexOfSteel_API_Core.md`
- `HexOfSteel_API_COMPLETE_WITH_PRIVATE.md` ⭐
- `HexOfSteel_API_Core_With_Private.md`

---

## 🔧 Understanding Private Member Access

**Key Point:** With Harmony, you can access and modify **ANY** private method or field!

### What You Can Do:

✅ **Patch private methods** - Hook into internal game logic
✅ **Read private fields** - Inspect hidden game state
✅ **Write private fields** - Modify internal values
✅ **Call private methods** - Trigger internal functions

### Example from Documentation:

If you find this in your generated docs:

```markdown
### Private Methods
- `private void CalculateScore(Player player)`

### Private Fields
- `private int _hiddenGold`
```

You can use them:

```csharp
// Patch the private method
[HarmonyPatch(typeof(GameData), "CalculateScore")]
class MyPatch { }

// Access the private field
var gold = Traverse.Create(player).Field("_hiddenGold").GetValue<int>();
```

📖 **Full guide:** [HARMONY_PRIVATE_ACCESS_GUIDE.md](HARMONY_PRIVATE_ACCESS_GUIDE.md)

---

## 📋 Current Configuration

**Currently enabled:**
```csharp
APIExplorerComplete.DumpCompleteAPIToFile();
```

This will generate: `HexOfSteel_API_COMPLETE_WITH_PRIVATE.md`

**When you're done generating documentation**, comment out the line to avoid regenerating on every game launch:

```csharp
// APIExplorerComplete.DumpCompleteAPIToFile();  // Done - no need to regenerate
```

---

## 📖 Documentation Files Reference

### Core Scripts:
1. **[APIExplorer.cs](Scripts/APIExplorer.cs)** - Original (console output)
2. **[APIExplorerToFile.cs](Scripts/APIExplorerToFile.cs)** - Public members only
3. **[APIExplorerComplete.cs](Scripts/APIExplorerComplete.cs)** - Public + Private members ⭐

### Guides:
1. **[API_EXPLORER_GUIDE.md](API_EXPLORER_GUIDE.md)** - Basic usage guide
2. **[HARMONY_PRIVATE_ACCESS_GUIDE.md](HARMONY_PRIVATE_ACCESS_GUIDE.md)** - Private member access guide ⭐
3. **[HARMONY_MODDING_MANUAL.md](HARMONY_MODDING_MANUAL.md)** - General Harmony guide
4. **[API_REFERENCE.md](API_REFERENCE.md)** - Manual API reference

### Utilities:
- **[CheckForAPIDoc.bat](CheckForAPIDoc.bat)** - Check for generated documentation

---

## 🎯 Recommended Workflow

### For Beginners:
1. Generate: `APIExplorerToFile.DumpCoreClassesOnly()`
2. Read: `HexOfSteel_API_Core.md`
3. Study: Public methods only
4. Learn: Basic patching with public methods

### For Intermediate:
1. Generate: `APIExplorerComplete.DumpCoreClassesWithPrivate()` ⭐ **BEST CHOICE**
2. Read: `HexOfSteel_API_Core_With_Private.md`
3. Study: Private methods and fields
4. Learn: Harmony Traverse and AccessTools

### For Advanced:
1. Generate: `APIExplorerComplete.DumpCompleteAPIToFile()`
2. Read: `HexOfSteel_API_COMPLETE_WITH_PRIVATE.md`
3. Explore: All available classes and members
4. Experiment: Deep game modifications

---

## ⚠️ Important Notes

### File Size Warning
`HexOfSteel_API_COMPLETE_WITH_PRIVATE.md` can be **very large** (10+ MB) because it includes:
- Every public class
- Every private class
- Every public and private member
- Hundreds of classes

**Recommendation:** Start with `DumpCoreClassesWithPrivate()` instead!

### Performance Note
The documentation generation happens during mod initialization and may cause a brief pause (2-5 seconds) when starting a scenario. This is normal.

### After First Run
Once you have your documentation, **comment out the generator line** to avoid regenerating the file every time you play.

---

## 🆘 Troubleshooting

### "File not generated"
1. Check that you uncommented the generator line in [ExampleMod.cs](Scripts/ExampleMod.cs)
2. Rebuild: `dotnet build`
3. Make sure the DLL was copied to the mods folder
4. Check Player.log for errors: Run [CheckForAPIDoc.bat](CheckForAPIDoc.bat)

### "Can't find the file"
The file is generated in the game's root directory:
```
D:\SteamLibrary\steamapps\common\Hex of Steel\
```

Use [CheckForAPIDoc.bat](CheckForAPIDoc.bat) to automatically locate it.

### "Game crashes during generation"
This usually means you're trying to generate the full API (`DumpCompleteAPIToFile()`).
Try the smaller version: `DumpCoreClassesWithPrivate()` instead.

---

## 🎓 Learning Path

1. **Start Here:** Generate core classes with private members
2. **Read:** [HARMONY_PRIVATE_ACCESS_GUIDE.md](HARMONY_PRIVATE_ACCESS_GUIDE.md)
3. **Study:** The generated documentation for classes you want to mod
4. **Practice:** Create simple patches for private methods
5. **Explore:** Use Traverse to access private fields
6. **Experiment:** Build your own mods using the discovered APIs

---

## 📊 What's in Each Documentation Level

### Public Only (Small)
```
GameData
├── Public Methods: GetInstance(), Save(), Load()
├── Public Properties: players, turnNumber
└── Public Fields: isMultiplayer
```

### With Private (Complete)
```
GameData
├── Public Methods: GetInstance(), Save(), Load()
├── Private Methods: InitializeInternal(), ValidateData(), UpdateCache()
├── Public Properties: players, turnNumber
├── Private Properties: InternalState, CachedData
├── Public Fields: isMultiplayer
├── Private Fields: _playerCache, _turnData, _isInitialized
└── Harmony Examples: How to access all private members!
```

---

## 🎮 Ready to Mod!

You now have everything you need to:
- ✅ Discover all public APIs
- ✅ Discover all private APIs (with Harmony!)
- ✅ Patch any method (public or private)
- ✅ Access any field (public or private)
- ✅ Build powerful mods

**Next:** Run the game and generate your documentation!

---

**Happy Modding! 🚀**
