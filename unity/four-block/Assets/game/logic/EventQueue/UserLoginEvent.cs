using game.logic.tilespawner;

namespace game.logic.EventQueue
{
    public class UserLoginEvent : IEvent
    {
        public string Username { get; }

        public UserLoginEvent(object source, string username)
        {
            Source = source;
            this.Username = username;
        }

        public EventId Id
        {
            get => EventId.UserLogin;
        }
        public object Source { get; }
    }
}