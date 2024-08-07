---
title: Overview
---
The repo DEMO-gravity-cubes contains a game where players drop sets of four blocks and build structures.

## Main Components

### Game Initialization

Game Initialization involves setting up the initial state of the game by creating and linking various game components such as the playfield, tiles, gravity strategies, and services. This process includes instantiating prefabs, linking view models, registering services, and adding updatable components to the dispatcher to ensure the game runs smoothly from the start.

- <SwmLink doc-title="Game initialization overview">[Game initialization overview](.swm/game-initialization-overview.wbhkk7sx.sw.md)</SwmLink>

### Debug Tools

Debug tools are utilities that assist developers in identifying and resolving issues within the codebase. They typically include features for executing specific commands, inspecting variables, and handling errors. In this project, the debug tools are implemented using classes like DebugInvoker and DebugReceiver, which manage and execute debugging commands such as 'vardump'. These tools streamline the debugging process by providing a structured way to invoke and handle various debugging actions.

- <SwmLink doc-title="Debug tools overview">[Debug tools overview](.swm/debug-tools-overview.uxk2ygsv.sw.md)</SwmLink>
- <SwmLink doc-title="Understanding vardump command">[Understanding vardump command](.swm/understanding-vardump-command.zl1w0751.sw.md)</SwmLink>

### Login Button

The Login Button is a UI element that, when clicked, triggers a user login event by fetching the username from the UserService and enqueuing a UserLoginEvent into the EventQueue.

- <SwmLink doc-title="Login button overview">[Login button overview](.swm/login-button-overview.rgjjfq6r.sw.md)</SwmLink>

### Game Logic

Game Logic refers to the core functionality that drives the game's mechanics, including the rules and behaviors that govern how the game operates. It encompasses various components such as gravity, tile spawning, and playfield management, which work together to create a cohesive gameplay experience. The logic ensures that blocks drop correctly, interact with each other as intended, and adhere to the game's rules, providing a structured and engaging environment for players.

- <SwmLink doc-title="Game logic overview">[Game logic overview](.swm/game-logic-overview.7bs9x6py.sw.md)</SwmLink>
- <SwmLink doc-title="Introduction to level based gravity strategy">[Introduction to level based gravity strategy](.swm/introduction-to-level-based-gravity-strategy.xcu81zy8.sw.md)</SwmLink>
- <SwmLink doc-title="Basic concepts of gravity">[Basic concepts of gravity](.swm/basic-concepts-of-gravity.lz3jrnzn.sw.md)</SwmLink>
- <SwmLink doc-title="The iservice class">[The iservice class](.swm/the-iservice-class.2qmty.sw.md)</SwmLink>
- **Event queue**
  - <SwmLink doc-title="Getting started with event queue">[Getting started with event queue](.swm/getting-started-with-event-queue.tzsi65k6.sw.md)</SwmLink>
  - <SwmLink doc-title="Getting started with event queue">[Getting started with event queue](.swm/getting-started-with-event-queue.l8mrhyf4.sw.md)</SwmLink>
- **Tilespawner**
  - <SwmLink doc-title="Overview of tile spawner">[Overview of tile spawner](.swm/overview-of-tile-spawner.aoiooh8p.sw.md)</SwmLink>
  - <SwmLink doc-title="Overview of tile spawner service">[Overview of tile spawner service](.swm/overview-of-tile-spawner-service.t29ghc8q.sw.md)</SwmLink>
  - <SwmLink doc-title="The ispawnable class">[The ispawnable class](.swm/the-ispawnable-class.6trcv.sw.md)</SwmLink>
- **Playfield**
  - <SwmLink doc-title="Introduction to playfield">[Introduction to playfield](.swm/introduction-to-playfield.reocj63c.sw.md)</SwmLink>
  - <SwmLink doc-title="Getting started with playfieldviewmodel">[Getting started with playfieldviewmodel](.swm/getting-started-with-playfieldviewmodel.l0rjifrh.sw.md)</SwmLink>
- **Tile**
  - <SwmLink doc-title="Exploring tile">[Exploring tile](.swm/exploring-tile.aohe4q0n.sw.md)</SwmLink>
  - <SwmLink doc-title="Introduction to tileview">[Introduction to tileview](.swm/introduction-to-tileview.utci9z0j.sw.md)</SwmLink>

### Network Services

Network Services refer to the components responsible for handling communication between the game and external servers. They include classes for making HTTP GET and POST requests, as well as services for managing user data and scores. These services ensure that the game can interact with remote servers to fetch and send data as needed.

- <SwmLink doc-title="Network services overview">[Network services overview](.swm/network-services-overview.77grb6to.sw.md)</SwmLink>
- <SwmLink doc-title="Basic concepts of httprequestfactory in network services">[Basic concepts of httprequestfactory in network services](.swm/basic-concepts-of-httprequestfactory-in-network-services.yuf4f2h6.sw.md)</SwmLink>
- <SwmLink doc-title="Exploring http requests in network services">[Exploring http requests in network services](.swm/exploring-http-requests-in-network-services.331hxw9s.sw.md)</SwmLink>

### Game Runner

GameRunner is responsible for managing the game's main loop, handling gravity calculations, and spawning new tiles. It updates the game's state by incrementing gravity and frame counters, and when certain conditions are met, it triggers the spawning of new tiles and enqueues spawn events.

- <SwmLink doc-title="Game runner overview">[Game runner overview](.swm/game-runner-overview.u5dqn3bu.sw.md)</SwmLink>
- <SwmLink doc-title="Basic concepts of game runner">[Basic concepts of game runner](.swm/basic-concepts-of-game-runner.v0h1s2ry.sw.md)</SwmLink>
- <SwmLink doc-title="Overview of dispatcher in game runner">[Overview of dispatcher in game runner](.swm/overview-of-dispatcher-in-game-runner.erfdj45g.sw.md)</SwmLink>
- <SwmLink doc-title="The iupdatable class">[The iupdatable class](.swm/the-iupdatable-class.x353y.sw.md)</SwmLink>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="other"><sup>Powered by [Swimm](/)</sup></SwmMeta>
