---
title: Basic concepts of Gravity
---
Gravity is a fundamental mechanic that influences how blocks behave in the game. It determines the downward force applied to the blocks, making them fall towards the bottom of the game area.

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:5:5" line-data="    public class GravityService : IUpdatable, IGravityService">`GravityService`</SwmToken> class is responsible for managing the gravity logic. It uses a strategy pattern to allow different implementations of gravity behavior through the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="8:3:3" line-data="        private IGravityStrategy _gravityStrategy;">`IGravityStrategy`</SwmToken> interface.

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="10:5:5" line-data="        public float CurrentGravity =&gt; _gravityStrategy.CurrentGravity;">`CurrentGravity`</SwmToken> property in the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:5:5" line-data="    public class GravityService : IUpdatable, IGravityService">`GravityService`</SwmToken> class provides the current gravity value by delegating to the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="10:5:5" line-data="        public float CurrentGravity =&gt; _gravityStrategy.CurrentGravity;">`CurrentGravity`</SwmToken> property of the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="8:5:5" line-data="        private IGravityStrategy _gravityStrategy;">`_gravityStrategy`</SwmToken> instance.

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="17:5:5" line-data="        public void Update()">`Update`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:5:5" line-data="    public class GravityService : IUpdatable, IGravityService">`GravityService`</SwmToken> class ensures that the gravity logic is updated every frame. If the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="8:5:5" line-data="        private IGravityStrategy _gravityStrategy;">`_gravityStrategy`</SwmToken> instance implements the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:9:9" line-data="    public class GravityService : IUpdatable, IGravityService">`IUpdatable`</SwmToken> interface, its <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="17:5:5" line-data="        public void Update()">`Update`</SwmToken> method is called to perform any necessary updates.

<SwmSnippet path="/unity/four-block/Assets/game/logic/Gravity.cs" line="6">

---

# <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:5:5" line-data="    public class GravityService : IUpdatable, IGravityService">`GravityService`</SwmToken> Class

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="6:5:5" line-data="    public class GravityService : IUpdatable, IGravityService">`GravityService`</SwmToken> class manages the gravity logic using a strategy pattern. It allows different implementations of gravity behavior through the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="8:3:3" line-data="        private IGravityStrategy _gravityStrategy;">`IGravityStrategy`</SwmToken> interface.

```c#
    public class GravityService : IUpdatable, IGravityService
    {
        private IGravityStrategy _gravityStrategy;

        public float CurrentGravity => _gravityStrategy.CurrentGravity;

        public GravityService(IGravityStrategy gravityStrategy)
        {
            _gravityStrategy = gravityStrategy;
        }

        public void Update()
        {
            if (_gravityStrategy is IUpdatable updatable)
            {
                updatable.Update();
            }
        }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/Gravity.cs" line="10">

---

# <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="10:5:5" line-data="        public float CurrentGravity =&gt; _gravityStrategy.CurrentGravity;">`CurrentGravity`</SwmToken> Property

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="10:5:5" line-data="        public float CurrentGravity =&gt; _gravityStrategy.CurrentGravity;">`CurrentGravity`</SwmToken> property provides the current gravity value by delegating to the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="10:5:5" line-data="        public float CurrentGravity =&gt; _gravityStrategy.CurrentGravity;">`CurrentGravity`</SwmToken> property of the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="10:9:9" line-data="        public float CurrentGravity =&gt; _gravityStrategy.CurrentGravity;">`_gravityStrategy`</SwmToken> instance.

```c#
        public float CurrentGravity => _gravityStrategy.CurrentGravity;
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/Gravity.cs" line="17">

---

# Update Method

The <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="17:5:5" line-data="        public void Update()">`Update`</SwmToken> method ensures that the gravity logic is updated every frame. If the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="19:4:4" line-data="            if (_gravityStrategy is IUpdatable updatable)">`_gravityStrategy`</SwmToken> instance implements the <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="19:8:8" line-data="            if (_gravityStrategy is IUpdatable updatable)">`IUpdatable`</SwmToken> interface, its <SwmToken path="unity/four-block/Assets/game/logic/Gravity.cs" pos="17:5:5" line-data="        public void Update()">`Update`</SwmToken> method is called to perform any necessary updates.

```c#
        public void Update()
        {
            if (_gravityStrategy is IUpdatable updatable)
            {
                updatable.Update();
            }
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
