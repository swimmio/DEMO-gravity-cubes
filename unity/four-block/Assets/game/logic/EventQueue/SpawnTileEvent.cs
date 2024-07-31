using game.logic.tilespawner;

namespace game.logic.EventQueue
{
    public class SpawnTileEvent : IEvent
    {
        public TileSpawnerService.CreateTileShapeDelegate CreateTileShapeDelegate { get; }

        public SpawnTileEvent(object source, TileSpawnerService.CreateTileShapeDelegate _createTileShapeDelegate)
        {
            Source = source;
            this.CreateTileShapeDelegate = _createTileShapeDelegate;
        }

        public EventId Id
        {
            get => EventId.SpawnTile;
        }
        public object Source { get; }
    }
}