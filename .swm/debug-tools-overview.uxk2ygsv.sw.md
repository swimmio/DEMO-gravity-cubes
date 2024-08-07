---
title: Debug Tools Overview
---
Debug Tools are used to facilitate the debugging process by allowing developers to execute specific commands and actions within the game.

The <SwmToken path="unity/four-block/Assets/debugtools/DebugInvoker.cs" pos="3:5:5" line-data="    public class DebugInvoker">`DebugInvoker`</SwmToken> class is responsible for setting and executing commands. It holds a reference to an <SwmToken path="unity/four-block/Assets/debugtools/DebugInvoker.cs" pos="5:3:3" line-data="        private ICommand _command;">`ICommand`</SwmToken> object and provides methods to set and execute this command.

The <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="5:5:5" line-data="    public class DebugReceiver">`DebugReceiver`</SwmToken> class maintains a list of supported commands and provides an <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="8:5:5" line-data="        public void Action(string action)">`Action`</SwmToken> method to execute these commands. If an unsupported command is attempted, it throws a <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="11:5:7" line-data="                throw new System.NotImplementedException();">`System.NotImplementedException`</SwmToken>.

The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="7:3:3" line-data="        public VardumpCommand(DebugReceiver receiver)">`VardumpCommand`</SwmToken> class is an example of a specific command that can be executed. It uses the <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="5:5:5" line-data="    public class DebugReceiver">`DebugReceiver`</SwmToken> to perform the 'vardump' action.

<SwmSnippet path="/unity/four-block/Assets/debugtools/DebugInvoker.cs" line="3">

---

# <SwmToken path="unity/four-block/Assets/debugtools/DebugInvoker.cs" pos="3:5:5" line-data="    public class DebugInvoker">`DebugInvoker`</SwmToken> Class

The <SwmToken path="unity/four-block/Assets/debugtools/DebugInvoker.cs" pos="3:5:5" line-data="    public class DebugInvoker">`DebugInvoker`</SwmToken> class is responsible for setting and executing commands. It holds a reference to an <SwmToken path="unity/four-block/Assets/debugtools/DebugInvoker.cs" pos="5:3:3" line-data="        private ICommand _command;">`ICommand`</SwmToken> object and provides methods to set and execute this command.

```c#
    public class DebugInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/debugtools/DebugReceiver.cs" line="5">

---

# <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="5:5:5" line-data="    public class DebugReceiver">`DebugReceiver`</SwmToken> Class

The <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="5:5:5" line-data="    public class DebugReceiver">`DebugReceiver`</SwmToken> class maintains a list of supported commands and provides an <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="8:5:5" line-data="        public void Action(string action)">`Action`</SwmToken> method to execute these commands. If an unsupported command is attempted, it throws a <SwmToken path="unity/four-block/Assets/debugtools/DebugReceiver.cs" pos="11:5:7" line-data="                throw new System.NotImplementedException();">`System.NotImplementedException`</SwmToken>.

```c#
    public class DebugReceiver
    {
        private List<string> supportedCommands = new List<string>() { "vardump" };
        public void Action(string action)
        {
            if(!(supportedCommands.Contains(action))){
                throw new System.NotImplementedException();
            }
        }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/debugtools/Vardump.cs" line="4">

---

# <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="7:3:3" line-data="        public VardumpCommand(DebugReceiver receiver)">`VardumpCommand`</SwmToken> Class

The <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="7:3:3" line-data="        public VardumpCommand(DebugReceiver receiver)">`VardumpCommand`</SwmToken> class is an example of a specific command that can be executed. It uses the <SwmToken path="unity/four-block/Assets/debugtools/Vardump.cs" pos="5:3:3" line-data="        private DebugReceiver _receiver;">`DebugReceiver`</SwmToken> to perform the 'vardump' action.

```c#
    {
        private DebugReceiver _receiver;

        public VardumpCommand(DebugReceiver receiver)
        {
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
