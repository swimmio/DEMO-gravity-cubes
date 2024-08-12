---
title: Overview
---
The repo DEMO-gravity-cubes contains a game where players drop sets of four blocks and build structures.

## Main Components

### Game Initialization

Game Initialization involves setting up the initial state of the game by creating and linking various game components such as the playfield, tiles, gravity strategies, and services. This process includes instantiating prefabs, linking view models, registering services, and adding updatable components to the dispatcher to ensure the game runs smoothly from the start.

- <SwmLink doc-title="Game Initialization Overview">[Game Initialization Overview](/.swm/game-initialization-overview.wbhkk7sx.sw.md)</SwmLink>

### Debug Tools

In this project, the debug tools are implemented using classes like DebugInvoker and <SwmToken path="/unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="5:5:5" line-data="    public class DebugReceiver">`DebugReceiver`</SwmToken>, which manage and execute debugging commands such as 'vardump'. These tools streamline the debugging process by providing a structured way to invoke and handle various debugging actions.

- <SwmLink doc-title="Debug Tools Overview">[Debug Tools Overview](/.swm/debug-tools-overview.uxk2ygsv.sw.md)</SwmLink>

### Game Logic

Game Logic refers to the core functionality that drives the game's mechanics, including the rules and behaviors that govern how the game operates. It encompasses various components such as gravity, tile spawning, and playfield management, which work together to create a cohesive gameplay experience. The logic ensures that blocks drop correctly, interact with each other as intended, and adhere to the game's rules, providing a structured and engaging environment for players.

- <SwmLink doc-title="Game Logic Overview">[Game Logic Overview](/.swm/game-logic-overview.7bs9x6py.sw.md)</SwmLink>
- <SwmLink doc-title="Basic concepts of Gravity">[Basic concepts of Gravity](/.swm/basic-concepts-of-gravity.lz3jrnzn.sw.md)</SwmLink>
- <SwmLink doc-title="Level Based Gravity Strategy">[Level Based Gravity Strategy](/.swm/level-based-gravity-strategy.xcu81zy8.sw.md)</SwmLink>
- **Event queue**
  - <SwmLink doc-title="Event Queue">[Event Queue](/.swm/event-queue.tzsi65k6.sw.md)</SwmLink>
- **Tilespawner**
  - <SwmLink doc-title="Overview of Tile Spawner">[Overview of Tile Spawner](/.swm/overview-of-tile-spawner.aoiooh8p.sw.md)</SwmLink>
  - <SwmLink doc-title="The ISpawnable class">[The ISpawnable class](/.swm/the-ispawnable-class.6trcv.sw.md)</SwmLink>
- **Playfield**
  - <SwmLink doc-title="Introduction to Playfield">[Introduction to Playfield](/.swm/introduction-to-playfield.reocj63c.sw.md)</SwmLink>
  - <SwmLink doc-title="Getting started with PlayFieldViewModel">[Getting started with PlayFieldViewModel](/.swm/getting-started-with-playfieldviewmodel.l0rjifrh.sw.md)</SwmLink>
- **Tile**
  - <SwmLink doc-title="Exploring Tile">[Exploring Tile](/.swm/exploring-tile.aohe4q0n.sw.md)</SwmLink>
  - <SwmLink doc-title="Introduction to TileView">[Introduction to TileView](/.swm/introduction-to-tileview.utci9z0j.sw.md)</SwmLink>

### Network Services

Network Services refer to the components responsible for handling communication between the game and external servers. They include classes for making HTTP GET and POST requests, as well as services for managing user data and scores. These services ensure that the game can interact with remote servers to fetch and send data as needed.

- <SwmLink doc-title="Network Services Overview">[Network Services Overview](/.swm/network-services-overview.77grb6to.sw.md)</SwmLink>
- <SwmLink doc-title="Basic concepts of HttpRequestFactory in Network Services">[Basic concepts of HttpRequestFactory in Network Services](/.swm/basic-concepts-of-httprequestfactory-in-network-services.yuf4f2h6.sw.md)</SwmLink>
- <SwmLink doc-title="Exploring HTTP Requests in Network Services">[Exploring HTTP Requests in Network Services](/.swm/exploring-http-requests-in-network-services.331hxw9s.sw.md)</SwmLink>

### Game Runner

<SwmToken path="/unity/four-block/Assets/gamerunner/GameRunner.cs" pos="11:4:4" line-data="public class GameRunner : IUpdatable">`GameRunner`</SwmToken> is responsible for managing the game's main loop, handling gravity calculations, and spawning new tiles. It updates the game's state by incrementing gravity and frame counters, and when certain conditions are met, it triggers the spawning of new tiles and enqueues spawn events.

- <SwmLink doc-title="Game Runner Overview">[Game Runner Overview](/.swm/game-runner-overview.u5dqn3bu.sw.md)</SwmLink>
- <SwmLink doc-title="Overview of Dispatcher in Game Runner">[Overview of Dispatcher in Game Runner](/.swm/overview-of-dispatcher-in-game-runner.erfdj45g.sw.md)</SwmLink>
- <SwmLink doc-title="The IUpdatable class">[The IUpdatable class](/.swm/the-iupdatable-class.x353y.sw.md)</SwmLink>

### Flows

- <SwmLink doc-title="Winning the Game and Submitting the Score">[Winning the Game and Submitting the Score](/.swm/winning-the-game-and-submitting-the-score.ctirxeyx.sw.md)</SwmLink>
- <SwmLink doc-title="Handling User Login with OnClick">[Handling User Login with OnClick](/.swm/handling-user-login-with-onclick.311gss39.sw.md)</SwmLink>

### 

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
