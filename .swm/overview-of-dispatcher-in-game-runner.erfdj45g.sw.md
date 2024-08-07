---
title: Overview of Dispatcher in Game Runner
---
Dispatcher is a class that manages a list of objects implementing the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:9:9" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`IUpdatable`</SwmToken> interface.

It initializes this list in the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="11:5:5" line-data="        private void Awake()">`Awake`</SwmToken> method, ensuring that it is ready when the game starts.

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="16:5:5" line-data="        private void Update()">`Update`</SwmToken> method iterates through each <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:9:9" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`IUpdatable`</SwmToken> object in the list and calls their <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="16:5:5" line-data="        private void Update()">`Update`</SwmToken> method, ensuring they are updated every frame.

New <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:9:9" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`IUpdatable`</SwmToken> objects can be added to the list using the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="24:5:5" line-data="        public void addUpdatable(IUpdatable updatable)">`addUpdatable`</SwmToken> method.

<SwmSnippet path="/unity/four-block/Assets/gamerunner/Dispatcher.cs" line="11">

---

# Dispatcher Initialization

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="11:5:5" line-data="        private void Awake()">`Awake`</SwmToken> method initializes the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:1:1" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`_updatables`</SwmToken> list, ensuring it is ready when the game starts.

```c#
        private void Awake()
        {
            _updatables = new List<IUpdatable>();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/gamerunner/Dispatcher.cs" line="16">

---

# Dispatcher Update Method

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="16:5:5" line-data="        private void Update()">`Update`</SwmToken> method iterates through each <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:9:9" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`IUpdatable`</SwmToken> object in the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="18:10:10" line-data="            foreach (var updatable in _updatables)">`_updatables`</SwmToken> list and calls their <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="16:5:5" line-data="        private void Update()">`Update`</SwmToken> method, ensuring they are updated every frame.

```c#
        private void Update()
        {
            foreach (var updatable in _updatables)
            {
                updatable.Update();
            }
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/gamerunner/Dispatcher.cs" line="24">

---

# Adding Updatables

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="24:5:5" line-data="        public void addUpdatable(IUpdatable updatable)">`addUpdatable`</SwmToken> method allows new <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="24:7:7" line-data="        public void addUpdatable(IUpdatable updatable)">`IUpdatable`</SwmToken> objects to be added to the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="26:1:1" line-data="            _updatables.Add(updatable);">`_updatables`</SwmToken> list.

```c#
        public void addUpdatable(IUpdatable updatable)
        {
            _updatables.Add(updatable);
        }
```

---

</SwmSnippet>

# Main functions

Main functions

<SwmSnippet path="/unity/four-block/Assets/gamerunner/Dispatcher.cs" line="11">

---

## Awake

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="11:5:5" line-data="        private void Awake()">`Awake`</SwmToken> function initializes the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:1:1" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`_updatables`</SwmToken> list, ensuring it is ready when the game starts.

```c#
        private void Awake()
        {
            _updatables = new List<IUpdatable>();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/gamerunner/Dispatcher.cs" line="16">

---

## Update

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="16:5:5" line-data="        private void Update()">`Update`</SwmToken> function iterates through each <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="13:9:9" line-data="            _updatables = new List&lt;IUpdatable&gt;();">`IUpdatable`</SwmToken> object in the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="18:10:10" line-data="            foreach (var updatable in _updatables)">`_updatables`</SwmToken> list and calls their <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="16:5:5" line-data="        private void Update()">`Update`</SwmToken> method, ensuring they are updated every frame.

```c#
        private void Update()
        {
            foreach (var updatable in _updatables)
            {
                updatable.Update();
            }
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/gamerunner/Dispatcher.cs" line="24">

---

## <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="24:5:5" line-data="        public void addUpdatable(IUpdatable updatable)">`addUpdatable`</SwmToken>

The <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="24:5:5" line-data="        public void addUpdatable(IUpdatable updatable)">`addUpdatable`</SwmToken> function allows new <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="24:7:7" line-data="        public void addUpdatable(IUpdatable updatable)">`IUpdatable`</SwmToken> objects to be added to the <SwmToken path="unity/four-block/Assets/gamerunner/Dispatcher.cs" pos="26:1:1" line-data="            _updatables.Add(updatable);">`_updatables`</SwmToken> list.

```c#
        public void addUpdatable(IUpdatable updatable)
        {
            _updatables.Add(updatable);
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
