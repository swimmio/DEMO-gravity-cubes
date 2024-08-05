namespace debugtools
{
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
}