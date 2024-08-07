---
title: Getting started with Event Queue
---
The Event Queue is a mechanism that manages events in the game logic. It ensures that events are processed in the order they are received.

Events are categorized by their <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>, and each type of event is stored in its own queue within a dictionary.

When an event is enqueued using the <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="15:5:5" line-data="        public void Enqueue(IEvent e)">`Enqueue`</SwmToken> method, it is added to the appropriate queue based on its <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="26:5:5" line-data="        public IEvent Dequeue(EventId id)">`Dequeue`</SwmToken> method is used to retrieve and remove the next event from the queue for a given <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="24:5:5" line-data="        public bool HasEvent(EventId id) =&gt; _queues.ContainsKey(id) &amp;&amp; _queues[id].Count &gt; 0;">`HasEvent`</SwmToken> method checks if there are any events in the queue for a specific <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

<SwmSnippet path="/unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" line="6">

---

# Event Queue Class

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="6:5:5" line-data="    public class EventQueue: IService">`EventQueue`</SwmToken> class initializes a dictionary to hold queues for different event types, identified by <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

```c#
    public class EventQueue: IService
    {
        private Dictionary<EventId, Queue<IEvent>> _queues;
        
        public EventQueue()
        {
            _queues = new Dictionary<EventId, Queue<IEvent>>();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" line="15">

---

# Enqueue Method

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="15:5:5" line-data="        public void Enqueue(IEvent e)">`Enqueue`</SwmToken> method adds an event to the appropriate queue based on its <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>. If the queue for the event type does not exist, it creates a new queue.

```c#
        public void Enqueue(IEvent e)
        {
            if(!_queues.ContainsKey(e.Id))
            {
                _queues[e.Id] = new Queue<IEvent>();
            }
            _queues[e.Id].Enqueue(e);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" line="26">

---

# Dequeue Method

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="26:5:5" line-data="        public IEvent Dequeue(EventId id)">`Dequeue`</SwmToken> method retrieves and removes the next event from the queue for a given <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="26:7:7" line-data="        public IEvent Dequeue(EventId id)">`EventId`</SwmToken>. If no events are available, it returns null.

```c#
        public IEvent Dequeue(EventId id)
        {
            if (HasEvent(id))
            {
                return _queues[id].Dequeue();
            }
            return null;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" line="24">

---

# <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="24:5:5" line-data="        public bool HasEvent(EventId id) =&gt; _queues.ContainsKey(id) &amp;&amp; _queues[id].Count &gt; 0;">`HasEvent`</SwmToken> Method

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="24:5:5" line-data="        public bool HasEvent(EventId id) =&gt; _queues.ContainsKey(id) &amp;&amp; _queues[id].Count &gt; 0;">`HasEvent`</SwmToken> method checks if there are any events in the queue for a specific <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="24:7:7" line-data="        public bool HasEvent(EventId id) =&gt; _queues.ContainsKey(id) &amp;&amp; _queues[id].Count &gt; 0;">`EventId`</SwmToken>.

```c#
        public bool HasEvent(EventId id) => _queues.ContainsKey(id) && _queues[id].Count > 0;

```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
