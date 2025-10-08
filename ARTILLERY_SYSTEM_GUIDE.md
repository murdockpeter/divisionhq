# Artillery System - User Guide

## Overview

The Artillery System adds configurable artillery strikes to your Division Enablers mod with three distinct strike modes and splash damage to adjacent hexes.

## Features

### Three Artillery Strike Modes

1. **Area Damage** (Default)
   - 30 damage to target hex
   - 15 damage to all adjacent hexes
   - Best for clustered enemy units

2. **Precision Strike**
   - 50 damage to single hex only
   - No splash damage
   - Best for high-value targets

3. **Suppression Barrage**
   - 20 damage to center hex
   - 12 damage to adjacent hexes
   - Wider area coverage
   - Best for general area denial

## How to Use

### Step 1: Open Division HQ
Press **'H'** to open the Division HQ panel (or use the on-screen button)

### Step 2: Request Artillery Support
Click on the **"Artillery Support"** button in the Division HQ panel

**Cost:** $200
**Cooldown:** 5 turns
**Max Uses:** 3 per game

### Step 3: Select Strike Mode
A configuration panel will appear with three options:
- Click on your preferred strike mode
- The selected mode will be highlighted
- Read the damage description for each mode

### Step 4: Confirm & Target
- Click **"CONFIRM & TARGET"** to activate targeting mode
- Or click **"CANCEL"** to go back

### Step 5: Strike!
- Click on any hex on the map to execute the artillery strike
- The strike will:
  - Damage all enemy units on that hex
  - Apply splash damage to adjacent hexes (if mode supports it)
  - Skip friendly units automatically

## Damage Mechanics

- Damage is applied to unit's **Current HP (CurrHP)**
- Units at 0 HP are destroyed
- Both ground and air units on a hex are affected
- Friendly fire protection: Your own units are never damaged

## Tips & Strategy

### Area Damage
- Use when enemies are in tight formation
- Excellent against stacked units
- Can hit 7 hexes total (center + 6 adjacent)

### Precision Strike
- Use against single high-value targets
- Best for commanders or heavy units
- No wasted damage on empty hexes

### Suppression Barrage
- Use for area denial
- Good for softening up multiple targets
- Lower damage but wider coverage

## Cooldown & Economy

- **Cost:** $200 per strike
- **Cooldown:** 5 turns after use
- **Limited Uses:** Only 3 strikes per game
- Plan your strikes carefully!

## Visual Feedback

- **On-screen messages** confirm:
  - When targeting mode is active
  - Which mode you're using
  - When strike is complete

- **Console logs** show:
  - Damage dealt to each unit
  - Units destroyed
  - Tiles affected

## Troubleshooting

### "Cannot request artillery support"
- Check if you have $200 available
- Artillery may be on cooldown
- You may have used all 3 strikes

### Targeting not working
- Make sure you clicked "CONFIRM" first
- The message "Artillery targeting active" should appear
- Try clicking directly on the hex center

### No damage dealt
- Verify there were enemy units on the target hex
- Friendly units are automatically skipped
- Check the console log for details

## Future Enhancements

Possible additions:
- Visual explosion effects
- Sound effects
- Additional strike modes
- Adjustable damage values
- Per-player strike limits

## Technical Details

### File Structure
- `ArtillerySystem.cs` - Core artillery logic
- `DivisionEnablersUI.cs` - Configuration panel UI
- `DivisionEnablers.cs` - Integration with enabler system

### API Used
- `Unit.CurrHP` - Unit health manipulation
- `Unit.OwnerPlayer` - Friendly fire detection
- `Tile.PosX/PosY` - Hex coordinates
- `Tile.neighbours` - Adjacent hex detection
- `TileGO.groundUnitGO/airUnitGO` - Unit detection

### Harmony Patches
- `Patch_TileGO_ArtilleryTargeting` - Intercepts tile clicks during targeting mode

## Credits

- **Created for:** Division Enablers Mod
- **Compatible with:** Hex Of Steel
- **Framework:** Harmony patching library

---

**Enjoy your new artillery support! 🎯💥**