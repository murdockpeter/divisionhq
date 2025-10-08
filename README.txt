Division Enablers - Hex of Steel Mod
====================================================================

Request special assets from Division HQ during gameplay!

This mod adds a Division HQ system that allows you to request special support
assets during battle, including Artillery Support, Air Reconnaissance, Supply
Drops, and Reinforcements. Each enabler has costs, cooldowns, and limited uses
to keep gameplay balanced.

====================================================================

Features
----------------
• Division HQ Panel - Press 'H' to open the request panel during your turn
• Artillery Support - Request heavy artillery strikes with multiple modes:
  - Area Damage: Wide blast radius for concentrated enemy positions
  - Precision Strike: Focused damage on a single hex
  - Suppression Barrage: Reduce enemy combat effectiveness
• Air Reconnaissance - Reveal enemy positions (coming soon)
• Supply Drops - Emergency supply delivery to units (coming soon)
• Reinforcements - Request additional units from Division reserve
• Cooldown System - Each enabler has a turn-based cooldown after use
• Cost Management - Enablers cost money, requiring strategic resource management
• Limited Uses - Some enablers have a maximum number of uses per game
• Persistent Data - Your enabler status is saved with your game

What is Harmony?
----------------
This mod uses Harmony, a .NET library that patches game methods at runtime.
Harmony makes it possible to extend Hex of Steel without modifying game files.

====================================================================

Installation
----------------
1. Download or clone this repository
2. Build the project:
   - In VS Code: Terminal → Run Task → dotnet: build
   - Or from the terminal: dotnet build
3. The compiled DLL will be in: output/net48/DivisionEnablers.dll
4. In Hex of Steel, create a mod folder:
   MODS/Division Enablers/Libraries/
5. Copy DivisionEnablers.dll to the Libraries folder
6. Copy 0Harmony.dll to the Libraries folder (from Libraries/ in this repo)
7. Enable the mod in Hex of Steel's mod menu
8. Start a game and press 'H' during your turn!

Usage
----------------
• Press 'H' during your turn to open the Division HQ panel
• Click on any available enabler to request it (costs money)
• Artillery Support opens a configuration panel:
  - Select your preferred strike mode
  - Click "Confirm & Target"
  - Click on a hex on the map to strike that location
• Enablers enter cooldown after use
• Some enablers have limited uses per game
• Your enabler status is saved with your game

Development
----------------
Prerequisites:
- .NET 8 SDK: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Visual Studio Code: https://code.visualstudio.com

Key Files:
- Scripts/DivisionEnablers.cs - Core mod logic and data structures
- Scripts/DivisionEnablersModEntry.cs - Mod entry point and Harmony initialization
- Scripts/DivisionEnablersUI.cs - UI panel creation and management
- Scripts/DivisionEnablersKeybindHandler.cs - Keyboard input handling
- Scripts/ArtillerySystem.cs - Artillery targeting and damage system
- Scripts/UIManagerPatch.cs - Prevents counters from hiding with panel open
- Scripts/PlayerHelper.cs - Helper functions for player money management

====================================================================

Debugging
----------------
If your mod doesn’t work or crashes, check the Player.log file. It records all errors and helpful debug messages.

Player.log locations:
- Windows: %USERPROFILE%\AppData\LocalLow\War Frogs Studio\Hex of Steel\Player.log
- MacOS: ~/Library/Logs/War Frogs Studio/Hex of Steel/Player.log
- Linux: ~/.config/unity3d/War Frogs Studio/Hex of Steel/Player.log

====================================================================

Resources
---------------------------------------------------------------------
- Hex of Steel Community: https://discord.gg/Tn63mrwJyH
- .NET 8 SDK: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Visual Studio Code (lightweight IDE): https://code.visualstudio.com
- Harmony Documentation: https://harmony.pardeike.net/

====================================================================

Known Issues
----------------
- After a game update, if the H key stops working, rebuild the mod DLL
- Some enabler effects (Air Recon, Supply Drops) are placeholders
- Artillery damage calculations may need balancing

Future Features
----------------
- Fully implemented Air Reconnaissance with fog of war reveal
- Supply Drop implementation with unit supply restoration
- Additional enabler types (Medical Evacuation, Signals Intelligence)
- Configurable costs and cooldowns via mod settings
- Visual effects for artillery strikes
- Sound effects for enabler activation

====================================================================

Contributing
----------------
Contributions are welcome! Feel free to:
- Report bugs or issues
- Suggest new enabler types or features
- Submit pull requests with improvements
- Share balance feedback

====================================================================

Credits
----------------
Mod by: Peter G. Robbins
For: Hex of Steel by War Frogs Studio
Built with: Harmony patching library

====================================================================

License & Compatibility
----------------
This mod is compatible with Hex of Steel version 8.0.4+
Always check for updates after game patches, as the game API may change.

For support and discussion:
- Hex of Steel Community Discord: https://discord.gg/Tn63mrwJyH
- Harmony Documentation: https://harmony.pardeike.net/