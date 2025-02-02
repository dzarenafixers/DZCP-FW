# DZCP-FW
The DZCP (DZ Arena Fixers Custom Project) is a modular and extensible library designed to manage in-game events, plugins, and configurations for game environments. Built using .NET 48, it provides a robust framework for handling various aspects of game development, such as event management, plugin loading, and configuration handling.

# API Reference

## GameEngine

- `void Start()`: Starts the game engine.

## EventManager

- `void TriggerEvent(string eventName)`: Triggers an event.

## CharacterManager

- `void AddCharacter(string character)`: Adds a character.
- `void ListCharacters()`: Lists all characters.

## ItemManager

- `void AddItem(string item)`: Adds an item.
- `void ListItems()`: Lists all items.

## gameRole

- `void ExecuteRole()`: Executes the logic for the game role.
# API Reference

## Event

- `string EventName`: The name of the event.
- `void Trigger()`: Method to trigger the event.

## EventManager

- `void RegisterEvent(Event gameEvent)`: Registers a new event.
- `void TriggerEvent(string eventName)`: Triggers an event by name.

## PlayerJoinedEvent

- `string PlayerName`: The name of the player who joined.
- `void Trigger()`: Triggers the player joined event.

## PlayerLeftEvent

- `string PlayerName`: The name of the player who left.
- `void Trigger()`: Triggers the player left event.

# Example Usage

Here's an example of how to use the framework:

```csharp
using SCPSL_Framework.Core;
using SCPSL_Framework.Events;
using SCPSL_Framework.Managers;
using SCPSL_Framework.Utilities;
using SCPSL_Framework.GameRoles.Exiled;

class Program
{
    static void Main()
    {
        GameEngine engine = new GameEngine();
        engine.Start();

        EventManager eventManager = new EventManager();
        eventManager.TriggerEvent("GameStarted");

        CharacterManager characterManager = new CharacterManager();
        characterManager.AddCharacter("Player1");
        characterManager.ListCharacters();

        ItemManager itemManager = new ItemManager();
        itemManager.AddItem("Gun");
        itemManager.ListItems();

        ExiledRole exiledRole = new ExiledRole();
        exiledRole.ExecuteRole();

        Logger.Log("Game initialized successfully.");
    }
}

# Example Usage

Here's an example of how to use the item management system:

```csharp
using SCPSL_Framework.Managers;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ItemManager itemManager = new ItemManager();

        Weapon pistol = new Weapon("Pistol", 25, 50, new Dictionary<string, int> { {"damage", 25}, {"range", 50} });
        itemManager.AddItem(pistol);

        Tool medkit = new Tool("Medkit", "Healing", new Dictionary<string, int> { {"healing", 50} });
        itemManager.AddItem(medkit);

        MiscItem document = new MiscItem("Document", "Classified information", new Dictionary<string, int> { {"pages", 5} });
        itemManager.AddItem(document);

        itemManager.ListItems();
    }
}
