using game.logic.EventQueue;
using game.logic.tile;
using game.service;
using gamerunner;
using UnityEngine;

namespace game.logic.playfield
{
    public class PlayFieldViewModel: IUpdatable
    {
        private PlayField _playField;
        private ServiceLocator _serviceLocator;

        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)
        {
            _playField = playField;
            _serviceLocator = serviceLocator;
            
            for (int x = 0; x < _playField.Width; x++)
            {
                for (int y = 0; y < _playField.Height; y++)
                {
                    _playField.Field[x, y] = new Tile(Color.black);
                }
            }
        }

        public int Width => _playField.Width;

        public int Height => _playField.Height;

        public ITileable[,] Tiles
        {
            get => _playField.Field;
            set => _playField.Field = value;
        }
        
        public ITileable GetTile(int x, int y)
        {
            return _playField.Field[x, y];
        }
        
        public void PlaceTile(ITileable tile, int x, int y)
        {
            _playField.Field[x, y] = tile;
        }

        public void Update()
        {
            var eventQueue = _serviceLocator.GetService<EventQueue.EventQueue>();
            var e = (SpawnTileEvent)eventQueue.Dequeue(EventId.SpawnTile);
            if (e != null)
            {
                var createTileShape = e.CreateTileShapeDelegate;
                var shape = createTileShape();
                PlaceTile(shape.Spawn(), 0, 0);
            }
        }
    }
}