---
title: Game Logic Overview
---
Game Logic refers to the core functionality that drives the game's mechanics and rules. It encompasses various components and services that manage the game's state and behavior.

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:5:5" line-data="    public class GravityService : IUpdatable, IGravityService">`GravityService`</SwmToken> class implements gravity mechanics, ensuring that blocks fall according to the game's rules. This service is crucial for simulating realistic block movement.

The <SwmToken path="unity/four-block/Assets/game/logic/IGravityStrategy.cs" pos="5:5:5" line-data="    public interface IGravityStrategy">`IGravityStrategy`</SwmToken> interface defines different strategies for applying gravity, allowing for flexibility in how gravity is handled based on different game conditions or levels.

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayField.cs" pos="3:6:6" line-data="namespace game.logic.playfield">`playfield`</SwmToken> class represents the game area where blocks are placed and interact. It manages the grid and ensures that blocks are correctly positioned and aligned.

Tile spawning is managed by the <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/OPiece.cs" pos="7:8:8" line-data="    public class OPiece: ISpawnable">`ISpawnable`</SwmToken> interface and its implementations, such as <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/OPiece.cs" pos="7:5:5" line-data="    public class OPiece: ISpawnable">`OPiece`</SwmToken> and `SPiece`. These classes handle the creation and placement of new blocks in the game.

The `EventQueue` component is responsible for managing and processing game events, ensuring that actions such as block movements and rotations are handled in the correct order.

The <SwmToken path="unity/four-block/Assets/game/logic/IDroppable.cs" pos="5:4:4" line-data="public class IDroppable">`IDroppable`</SwmToken> interface defines the behavior of blocks that can be dropped, ensuring consistency in how different types of blocks interact with the playfield.

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes"><sup>Powered by [Swimm](https://staging.swimm.cloud/)</sup></SwmMeta>
