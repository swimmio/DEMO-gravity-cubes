using System.Collections.Generic;

namespace debugtools
{
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
}