# Mod Analysis

This document provides an analysis of the Harmony-based mod for the Hex of Steel computer wargame.

## Core Feature: Division Enablers

The main feature of this mod is the "Division Enablers" system. This system allows players to request special assets from a "Division HQ" during gameplay. These assets, called "enablers," provide various forms of support to the player.

### Enabler Types

The following enabler types are available:

*   **Artillery Support:** A configurable artillery strike with different modes.
*   **Air Reconnaissance:** Reveals enemy units in a targeted area.
*   **Supply Drop:** Provides supplies to units.
*   **Reinforcements:** Adds new units to the player's army.
*   **Tactical Air Strike:** A targeted air attack.
*   **Medical Evacuation:** Heals units.
*   **Signals Intelligence:** Reveals enemy positions.

### Enabler Mechanics

Each enabler has the following properties:

*   **Cost:** A certain amount of money is required to request an enabler.
*   **Cooldown:** After an enabler is used, there is a cooldown period before it can be used again.
*   **Uses:** Some enablers have a limited number of uses per game.

### User Interface

The mod includes a custom UI for the Division Enablers system. The UI can be opened by pressing the 'H' key or by clicking a "Division HQ" button on the screen. The UI displays the available enablers, their costs, cooldowns, and remaining uses.

## Artillery System

The artillery system is a component of the Division Enablers feature. It implements a configurable artillery strike that can be requested as an enabler.

### Artillery Modes

There are three different artillery modes:

*   **Area Damage:** High damage to the target hex and medium damage to adjacent hexes.
*   **Precision Strike:** Very high damage to a single hex.
*   **Suppression Barrage:** Low damage over a wider area.

### Targeting

The player can select a target hex for the artillery strike using a targeting UI. The artillery strike damages units in the target hex and surrounding hexes, depending on the selected mode. The system also plays sound effects for the artillery strike.

## Developer Tools

The mod includes several tools for developers.

### API Explorers

The API explorers are utilities that can be used to inspect the game's API. These tools can dump the public or complete (including private members) API to the log or to a Markdown file. This is a very useful feature for mod developers.

### Player Log Opener

This is a simple utility that opens the `Player.log` file in the system's file explorer.

## Other Features

The mod includes several other features and examples.

### Custom Data

The mod includes an example of how to store custom data in the game's save files. The example implements a "diplomacy score" that can be used to create a custom victory condition.

### Localization

The mod shows how to add custom translations for different languages.

### Custom Policies

The mod demonstrates how to add a new policy to the game, with a custom icon and effects.

### Runtime Image Loader

This is a utility for loading images from disk at runtime. This is useful for loading custom icons for policies or units.

### Harmony Patches

The mod includes several other Harmony patches that modify various aspects of the game, such as war declarations, AI manpower growth, and unit upkeep costs.

### UI Examples

The mod includes examples of how to create custom UI elements, such as windows and buttons.
