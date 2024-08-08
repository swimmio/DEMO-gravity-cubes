---
title: Event Queue
---
The Event Queue is a mechanism that manages events in the game logic. It ensures that events are processed in the order they are received.

Events are categorized by their <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>, and each type of event is stored in its own queue within a dictionary.

When an event is enqueued using the <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="15:5:5" line-data="        public void Enqueue(IEvent e)">`Enqueue`</SwmToken> method, it is added to the appropriate queue based on its <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="26:5:5" line-data="        public IEvent Dequeue(EventId id)">`Dequeue`</SwmToken> method is used to retrieve and remove the next event from the queue for a given <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

The <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="24:5:5" line-data="        public bool HasEvent(EventId id) =&gt; _queues.ContainsKey(id) &amp;&amp; _queues[id].Count &gt; 0;">`HasEvent`</SwmToken> method checks if there are any events in the queue for a specific <SwmToken path="unity/four-block/Assets/game/logic/EventQueue/EventQueue.cs" pos="8:5:5" line-data="        private Dictionary&lt;EventId, Queue&lt;IEvent&gt;&gt; _queues;">`EventId`</SwmToken>.

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes"><sup>Powered by [Swimm](https://staging.swimm.cloud/)</sup></SwmMeta>
