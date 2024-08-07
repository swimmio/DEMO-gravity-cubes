---
title: Overview of Tile Spawner
---
Tilespawner is responsible for generating and managing the different types of pieces in the game.

It includes various classes like <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/IPiece.cs" pos="7:5:5" line-data="    public class IPiece: ISpawnable">`IPiece`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="27:15:15" line-data="        private static ISpawnable SpawnSPiece() =&gt; new SPiece();">`SPiece`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="26:15:15" line-data="        private static ISpawnable SpawnOPiece() =&gt; new OPiece();">`OPiece`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="25:15:15" line-data="        private static ISpawnable SpawnLPiece() =&gt; new LPiece();">`LPiece`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="29:15:15" line-data="        private static ISpawnable SpawnZPiece() =&gt; new ZPiece();">`ZPiece`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="24:15:15" line-data="        private static ISpawnable SpawnJPiece() =&gt; new JPiece();">`JPiece`</SwmToken>, and <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="28:15:15" line-data="        private static ISpawnable SpawnTPiece() =&gt; new TPiece();">`TPiece`</SwmToken>, each implementing the <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/IPiece.cs" pos="7:8:8" line-data="    public class IPiece: ISpawnable">`ISpawnable`</SwmToken> interface.

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken> class is a key component that likely handles the logic for spawning these pieces during the game.

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="8">

---

## <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken> Class

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken> class is defined within the <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="8:2:6" line-data="namespace game.logic.tilespawner">`game.logic.tilespawner`</SwmToken> namespace and implements the <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:8:8" line-data="    public class TileSpawnerService: IService">`IService`</SwmToken> interface.

```c#
namespace game.logic.tilespawner
{
    public class TileSpawnerService: IService
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="14">

---

## Piece Delegates

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="14:6:6" line-data="        List&lt;CreateTileShapeDelegate&gt; _pieces = new List&lt;CreateTileShapeDelegate&gt;{">`_pieces`</SwmToken> list contains delegates for creating each type of piece, such as <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="15:1:1" line-data="            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece">`SpawnIPiece`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="15:4:4" line-data="            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece">`SpawnJPiece`</SwmToken>, etc.

```c#
        List<CreateTileShapeDelegate> _pieces = new List<CreateTileShapeDelegate>{
            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece
        };
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="18">

---

## Constructor and Shuffle Method

The constructor of <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="18:3:3" line-data="        public TileSpawnerService()">`TileSpawnerService`</SwmToken> calls the <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="20:1:1" line-data="            Shuffle();">`Shuffle`</SwmToken> method to randomize the order of pieces.

```c#
        public TileSpawnerService()
        {
            Shuffle();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/IPiece.cs" line="5">

---

## Piece Classes

Classes like <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/IPiece.cs" pos="7:5:5" line-data="    public class IPiece: ISpawnable">`IPiece`</SwmToken> implement the <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/IPiece.cs" pos="7:8:8" line-data="    public class IPiece: ISpawnable">`ISpawnable`</SwmToken> interface, defining the behavior of each piece.

```c#
namespace game.logic.tilespawner
{
    public class IPiece: ISpawnable
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
