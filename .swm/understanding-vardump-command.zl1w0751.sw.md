---
title: Understanding Vardump Command
---
Vardump is a command class used for debugging purposes.

It is part of the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="1:3:3" line-data="﻿namespace debugtools">`debugtools`</SwmToken> namespace.

The class contains a private field <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:5:5" line-data="        private DebugReceiver _receiver;">`_receiver`</SwmToken> of type <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:3:3" line-data="        private DebugReceiver _receiver;">`DebugReceiver`</SwmToken>.

The constructor of <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="3:5:5" line-data="    public class VardumpCommand">`VardumpCommand`</SwmToken> initializes the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:5:5" line-data="        private DebugReceiver _receiver;">`_receiver`</SwmToken> field with an instance of <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:3:3" line-data="        private DebugReceiver _receiver;">`DebugReceiver`</SwmToken>.

The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="12:5:5" line-data="        public void Execute()">`Execute`</SwmToken> method of <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="3:5:5" line-data="    public class VardumpCommand">`VardumpCommand`</SwmToken> triggers the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="14:3:3" line-data="            _receiver.Action(&quot;vardump&quot;);">`Action`</SwmToken> method on the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:5:5" line-data="        private DebugReceiver _receiver;">`_receiver`</SwmToken> object with the argument "vardump".

<SwmSnippet path="/unity/four-block/Assets/debugtools/Vardump.cs" line="3">

---

## Vardump Command Class

The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="3:5:5" line-data="    public class VardumpCommand">`VardumpCommand`</SwmToken> class is defined within the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="1:3:3" line-data="﻿namespace debugtools">`debugtools`</SwmToken> namespace. It contains a private field <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:5:5" line-data="        private DebugReceiver _receiver;">`_receiver`</SwmToken> of type <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:3:3" line-data="        private DebugReceiver _receiver;">`DebugReceiver`</SwmToken> and a constructor that initializes this field. The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="12:5:5" line-data="        public void Execute()">`Execute`</SwmToken> method triggers the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="14:3:3" line-data="            _receiver.Action(&quot;vardump&quot;);">`Action`</SwmToken> method on the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:5:5" line-data="        private DebugReceiver _receiver;">`_receiver`</SwmToken> object with the argument 'vardump'.

```c#
    public class VardumpCommand
    {
        private DebugReceiver _receiver;

        public VardumpCommand(DebugReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action("vardump");
        }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/debugtools/Vardump.cs" line="12">

---

## Execute Method

The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="12:5:5" line-data="        public void Execute()">`Execute`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="3:5:5" line-data="    public class VardumpCommand">`VardumpCommand`</SwmToken> class calls the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="14:3:3" line-data="            _receiver.Action(&quot;vardump&quot;);">`Action`</SwmToken> method on the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="14:1:1" line-data="            _receiver.Action(&quot;vardump&quot;);">`_receiver`</SwmToken> object, passing 'vardump' as an argument. This method is used to perform the actual debugging action.

```c#
        public void Execute()
        {
            _receiver.Action("vardump");
        }
```

---

</SwmSnippet>

# Main functions

There are several main functions in this class. Some of them are the constructor and the Execute method. We will dive a little into both.

<SwmSnippet path="/unity/four-block/Assets/debugtools/Vardump.cs" line="7">

---

## <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="7:3:3" line-data="        public VardumpCommand(DebugReceiver receiver)">`VardumpCommand`</SwmToken> Constructor

The constructor of the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="7:3:3" line-data="        public VardumpCommand(DebugReceiver receiver)">`VardumpCommand`</SwmToken> class initializes the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="9:1:1" line-data="            _receiver = receiver;">`_receiver`</SwmToken> field with an instance of <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="7:5:5" line-data="        public VardumpCommand(DebugReceiver receiver)">`DebugReceiver`</SwmToken>. This setup is essential for the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="12:5:5" line-data="        public void Execute()">`Execute`</SwmToken> method to function correctly, as it relies on <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="9:1:1" line-data="            _receiver = receiver;">`_receiver`</SwmToken> to perform its action.

```c#
        public VardumpCommand(DebugReceiver receiver)
        {
            _receiver = receiver;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/debugtools/Vardump.cs" line="12">

---

## Execute Method

The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="12:5:5" line-data="        public void Execute()">`Execute`</SwmToken> method of the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="3:5:5" line-data="    public class VardumpCommand">`VardumpCommand`</SwmToken> class triggers the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="14:3:3" line-data="            _receiver.Action(&quot;vardump&quot;);">`Action`</SwmToken> method on the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="14:1:1" line-data="            _receiver.Action(&quot;vardump&quot;);">`_receiver`</SwmToken> object with the argument "vardump". This method is crucial for executing the debugging action associated with the Vardump command.

```c#
        public void Execute()
        {
            _receiver.Action("vardump");
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
