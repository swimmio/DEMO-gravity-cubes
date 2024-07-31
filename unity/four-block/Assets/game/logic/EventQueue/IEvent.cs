namespace game.logic.EventQueue
{
    public interface IEvent
    {
        EventId Id { get; }
        object Source { get; }
    }
}