---
title: Introduction to TileView
---
<SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:5:5" line-data="    public class TileView : MonoBehaviour">`TileView`</SwmToken> is a class that extends <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:9:9" line-data="    public class TileView : MonoBehaviour">`MonoBehaviour`</SwmToken> and is responsible for rendering the visual representation of a tile in the game.

It uses a <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="7:3:3" line-data="        public SpriteRenderer TileSprite;">`SpriteRenderer`</SwmToken>, referenced by the public field <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="7:5:5" line-data="        public SpriteRenderer TileSprite;">`TileSprite`</SwmToken>, to display the tile's sprite.

The private field <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:5:5" line-data="        private TileViewModel _tileVM;">`_tileVM`</SwmToken> holds a reference to the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:3:3" line-data="        private TileViewModel _tileVM;">`TileViewModel`</SwmToken>, which contains the tile's data.

The <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="15:5:5" line-data="        public void Link(TileViewModel tileVM)">`Link`</SwmToken> method is used to associate a <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:3:3" line-data="        private TileViewModel _tileVM;">`TileViewModel`</SwmToken> with the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:5:5" line-data="    public class TileView : MonoBehaviour">`TileView`</SwmToken> and set the tile's position based on the model's coordinates.

The <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="21:3:3" line-data="        void Update()">`Update`</SwmToken> method is intended to refresh the tile's view based on the current state of the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:3:3" line-data="        private TileViewModel _tileVM;">`TileViewModel`</SwmToken>.

<SwmSnippet path="/unity/four-block/Assets/game/logic/tile/TileView.cs" line="5">

---

## <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:5:5" line-data="    public class TileView : MonoBehaviour">`TileView`</SwmToken> Class

The <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:5:5" line-data="    public class TileView : MonoBehaviour">`TileView`</SwmToken> class extends <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:9:9" line-data="    public class TileView : MonoBehaviour">`MonoBehaviour`</SwmToken> and includes a <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="7:3:3" line-data="        public SpriteRenderer TileSprite;">`SpriteRenderer`</SwmToken> for displaying the tile's sprite and a private <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:3:3" line-data="        private TileViewModel _tileVM;">`TileViewModel`</SwmToken> to hold the tile's data.

```c#
    public class TileView : MonoBehaviour
    {
        public SpriteRenderer TileSprite;
        
        private TileViewModel _tileVM;

        private void Start()
        {
        }
        
        public void Link(TileViewModel tileVM)
        {
            _tileVM = tileVM;
            this.transform.position = new Vector3(tileVM.X, tileVM.Y, 0);
        }

        void Update()
        {
            // Update the view based on the _tileVM here
        }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tile/TileView.cs" line="15">

---

## Link Method

The Link method associates a <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="15:7:7" line-data="        public void Link(TileViewModel tileVM)">`TileViewModel`</SwmToken> with the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:5:5" line-data="    public class TileView : MonoBehaviour">`TileView`</SwmToken> and sets the tile's position based on the model's coordinates.

```c#
        public void Link(TileViewModel tileVM)
        {
            _tileVM = tileVM;
            this.transform.position = new Vector3(tileVM.X, tileVM.Y, 0);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tile/TileView.cs" line="21">

---

## Update Method

The Update method is intended to refresh the tile's view based on the current state of the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:3:3" line-data="        private TileViewModel _tileVM;">`TileViewModel`</SwmToken>.

```c#
        void Update()
        {
            // Update the view based on the _tileVM here
        }
```

---

</SwmSnippet>

# Main functions

There are several main functions in this folder. Some of them are Start, Link, and Update. We will dive a little into Link and Update.

<SwmSnippet path="/unity/four-block/Assets/game/logic/tile/TileView.cs" line="15">

---

## Link

The <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="15:5:5" line-data="        public void Link(TileViewModel tileVM)">`Link`</SwmToken> method is used to associate a <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="15:7:7" line-data="        public void Link(TileViewModel tileVM)">`TileViewModel`</SwmToken> with the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="5:5:5" line-data="    public class TileView : MonoBehaviour">`TileView`</SwmToken> and set the tile's position based on the model's coordinates. This method ensures that the visual representation of the tile is correctly positioned in the game world according to its data model.

```c#
        public void Link(TileViewModel tileVM)
        {
            _tileVM = tileVM;
            this.transform.position = new Vector3(tileVM.X, tileVM.Y, 0);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/tile/TileView.cs" line="21">

---

## Update

The <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="21:3:3" line-data="        void Update()">`Update`</SwmToken> method is intended to refresh the tile's view based on the current state of the <SwmToken path="unity/four-block/Assets/game/logic/tile/TileView.cs" pos="9:3:3" line-data="        private TileViewModel _tileVM;">`TileViewModel`</SwmToken>. This method would typically contain logic to update the visual aspects of the tile, such as its sprite or position, to reflect any changes in the underlying data model.

```c#
        void Update()
        {
            // Update the view based on the _tileVM here
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
