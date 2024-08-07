---
title: Overview of Tile Spawner Service
---
The Tile Spawner Service is responsible for generating new tile shapes in the game.

It maintains a list of delegates that create different types of tile shapes, such as I, J, L, O, S, T, and Z pieces.

Upon initialization, the service shuffles the list of tile creation delegates to ensure randomness.

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="31:5:5" line-data="        public CreateTileShapeDelegate Spawn()">`Spawn`</SwmToken> method shuffles the list again and returns the first delegate, which is then used to create a new tile shape.

The shuffling mechanism uses a random number generator to swap elements in the list, ensuring that the order of tile shapes is unpredictable.

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="18">

---

## Initialization

Upon initialization, the Tile Spawner Service shuffles the list of tile creation delegates to ensure randomness.

```c#
        public TileSpawnerService()
        {
            Shuffle();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="12">

---

## Tile Creation Delegates

The service maintains a list of delegates that create different types of tile shapes, such as I, J, L, O, S, T, and Z pieces.

```c#
        public delegate ISpawnable CreateTileShapeDelegate();
        
        List<CreateTileShapeDelegate> _pieces = new List<CreateTileShapeDelegate>{
            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece
        };
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="38">

---

## Shuffling Mechanism

The shuffling mechanism uses a random number generator to swap elements in the list, ensuring that the order of tile shapes is unpredictable.

```c#
        private void Shuffle()  
        {  
            var n = _pieces.Count;  
            while (n > 1) {  
                n--;  
                var k = rng.Next(n + 1);  
                (_pieces[k], _pieces[n]) = (_pieces[n], _pieces[k]);
            }  
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="31">

---

## Spawning Tiles

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="31:5:5" line-data="        public CreateTileShapeDelegate Spawn()">`Spawn`</SwmToken> method shuffles the list again and returns the first delegate, which is then used to create a new tile shape.

```c#
        public CreateTileShapeDelegate Spawn()
        {
            Shuffle();
            return _pieces.First();
        }
```

---

</SwmSnippet>

# Main functions

There are several main functions in this folder. Some of them are <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken>, Spawn, and Shuffle. We will dive a little into <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken> and Spawn.

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="10">

---

## <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken>

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="10:5:5" line-data="    public class TileSpawnerService: IService">`TileSpawnerService`</SwmToken> class is responsible for managing the creation of different tile shapes. It initializes a list of delegates that point to methods for creating each type of tile shape and shuffles this list to ensure randomness.

```c#
    public class TileSpawnerService: IService
    {
        public delegate ISpawnable CreateTileShapeDelegate();
        
        List<CreateTileShapeDelegate> _pieces = new List<CreateTileShapeDelegate>{
            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece
        };

        public TileSpawnerService()
        {
            Shuffle();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="31">

---

## Spawn

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="31:5:5" line-data="        public CreateTileShapeDelegate Spawn()">`Spawn`</SwmToken> method shuffles the list of tile creation delegates and returns the first delegate in the list. This delegate is then used to create a new tile shape, ensuring that the order of tile shapes is unpredictable.

```c#
        public CreateTileShapeDelegate Spawn()
        {
            Shuffle();
            return _pieces.First();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" line="38">

---

## Shuffle

The <SwmToken path="unity/four-block/Assets/game/logic/tilespawner/TileSpawnerService.cs" pos="38:5:5" line-data="        private void Shuffle()  ">`Shuffle`</SwmToken> method uses a random number generator to swap elements in the list of tile creation delegates. This ensures that the order of tile shapes is randomized each time the list is shuffled.

```c#
        private void Shuffle()  
        {  
            var n = _pieces.Count;  
            while (n > 1) {  
                n--;  
                var k = rng.Next(n + 1);  
                (_pieces[k], _pieces[n]) = (_pieces[n], _pieces[k]);
            }  
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
