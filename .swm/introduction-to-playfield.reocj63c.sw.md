---
title: Introduction to Playfield
---
Playfield is a core component that defines the grid where the game takes place. It is represented by a two-dimensional array of tiles.

The Playfield class contains constants for the width and height of the grid, ensuring a fixed size for the game area.

The Playfield class also includes properties to access the width and height of the grid, which are used throughout the game logic.

The Playfield is instantiated and managed by the <SwmToken path="unity/four-block/Assets/Initialisation/GameInitialiser.cs" pos="33:9:9" line-data="        var playFieldVM = new PlayFieldViewModel(playField, serviceLocator);">`PlayFieldViewModel`</SwmToken>, which interacts with the Playfield to update and render the game state.

The Playfield is initialized with a grid of tiles, each represented by an <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayField.cs" pos="13:3:3" line-data="        public ITileable[,] Field = new ITileable[FieldWidth, FieldHeight];">`ITileable`</SwmToken> object, which can be manipulated during the game.

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayField.cs" line="5">

---

Playfield Class The Playfield class defines the grid's width and height and initializes the grid with tiles.

```c#
    public class PlayField
    {
        private const int FieldWidth = 10;
        private const int FieldHeight = 22;

        public int Width => FieldWidth;
        public int Height => FieldHeight;

        public ITileable[,] Field = new ITileable[FieldWidth, FieldHeight];
    
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/Initialisation/GameInitialiser.cs" line="32">

---

Playfield Initialization The Playfield is instantiated in the <SwmToken path="unity/four-block/Assets/Initialisation/GameInitialiser.cs" pos="14:4:4" line-data="public class GameInitialiser : MonoBehaviour">`GameInitialiser`</SwmToken>.

```c#
        var playField = new PlayField();
        var playFieldVM = new PlayFieldViewModel(playField, serviceLocator);
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" line="10">

---

Playfield Management The <SwmToken path="unity/four-block/Assets/game/logic/playfield/PlayFieldViewModel.cs" pos="14:3:3" line-data="        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)">`PlayFieldViewModel`</SwmToken> manages the Playfield and updates the game state.

```c#
    {
        private PlayField _playField;
        private ServiceLocator _serviceLocator;

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
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
