---
title: Getting started with PlayFieldViewModel
---
The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="14:3:3" line-data="        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)">`PlayFieldViewModel`</SwmToken> is a class that implements the <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="9:8:8" line-data="    public class PlayFieldViewModel: IUpdatable">`IUpdatable`</SwmToken> interface and serves as the view model for the playfield in the game.

It initializes the playfield with a grid of tiles, setting each tile to a default color.

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="14:3:3" line-data="        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)">`PlayFieldViewModel`</SwmToken> provides properties to access the width and height of the playfield, as well as the tiles within it.

It includes methods to get a specific tile, place a tile at a specific location, and update the playfield based on events from an event queue.

The update method dequeues events related to spawning tiles and places new tiles on the playfield accordingly.

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="14">

---

## Initialization

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="14:3:3" line-data="        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)">`PlayFieldViewModel`</SwmToken> constructor initializes the playfield with a grid of tiles, setting each tile to a default color.

```c#
        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)
        {
            _playField = playField;
            _serviceLocator = serviceLocator;
            
            for (int x = 0; x < _playField.Width; x++)
            {
                for (int y = 0; y < _playField.Height; y++)
                {
                    _playField.Field[x, y] = new Tile(Color.black);
                }
            }
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="28">

---

## Properties

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="14:3:3" line-data="        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)">`PlayFieldViewModel`</SwmToken> provides properties to access the width and height of the playfield, as well as the tiles within it.

```c#
        public int Width => _playField.Width;

        public int Height => _playField.Height;

        public ITileable[,] Tiles
        {
            get => _playField.Field;
            set => _playField.Field = value;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="38">

---

## Methods

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="14:3:3" line-data="        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)">`PlayFieldViewModel`</SwmToken> includes methods to get a specific tile and place a tile at a specific location.

```c#
        public ITileable GetTile(int x, int y)
        {
            return _playField.Field[x, y];
        }
        
        public void PlaceTile(ITileable tile, int x, int y)
        {
            _playField.Field[x, y] = tile;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="48">

---

## Update Method

The update method dequeues events related to spawning tiles and places new tiles on the playfield accordingly.

```c#
        public void Update()
        {
            var eventQueue = _serviceLocator.GetService<EventQueue.EventQueue>();
            var e = (SpawnTileEvent)eventQueue.Dequeue(EventId.SpawnTile);
            if (e != null)
            {
                var createTileShape = e.CreateTileShapeDelegate;
                var shape = createTileShape();
                PlaceTile(shape.Spawn(), 0, 0);
            }
        }
```

---

</SwmSnippet>

# Main functions

There are several main functions in this class. Some of them are <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="38:5:5" line-data="        public ITileable GetTile(int x, int y)">`GetTile`</SwmToken>, <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="43:5:5" line-data="        public void PlaceTile(ITileable tile, int x, int y)">`PlaceTile`</SwmToken>, and Update. We will dive a little into these functions.

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="38">

---

## <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="38:5:5" line-data="        public ITileable GetTile(int x, int y)">`GetTile`</SwmToken>

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="38:5:5" line-data="        public ITileable GetTile(int x, int y)">`GetTile`</SwmToken> function retrieves a tile from the playfield at the specified coordinates.

```c#
        public ITileable GetTile(int x, int y)
        {
            return _playField.Field[x, y];
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="43">

---

## <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="43:5:5" line-data="        public void PlaceTile(ITileable tile, int x, int y)">`PlaceTile`</SwmToken>

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="43:5:5" line-data="        public void PlaceTile(ITileable tile, int x, int y)">`PlaceTile`</SwmToken> function places a tile at the specified coordinates in the playfield.

```c#
        public void PlaceTile(ITileable tile, int x, int y)
        {
            _playField.Field[x, y] = tile;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="48">

---

## Update

The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="48:5:5" line-data="        public void Update()">`Update`</SwmToken> function processes events from the event queue, specifically handling the spawning of new tiles and placing them on the playfield.

```c#
        public void Update()
        {
            var eventQueue = _serviceLocator.GetService<EventQueue.EventQueue>();
            var e = (SpawnTileEvent)eventQueue.Dequeue(EventId.SpawnTile);
            if (e != null)
            {
                var createTileShape = e.CreateTileShapeDelegate;
                var shape = createTileShape();
                PlaceTile(shape.Spawn(), 0, 0);
            }
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
