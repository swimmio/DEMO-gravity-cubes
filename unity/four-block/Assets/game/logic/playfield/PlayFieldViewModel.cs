using game.logic.tile;
using UnityEngine;

namespace game.logic.playfield
{
    public class PlayFieldViewModel
    {
        private PlayField _playField;

        public PlayFieldViewModel(PlayField playField)
        {
            _playField = playField;
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
    }
}