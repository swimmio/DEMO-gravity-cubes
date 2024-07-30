using game.logic.playfield;
using UnityEngine;

namespace game.logic.tile
{
    public class TileViewModel
    {
        private PlayFieldViewModel _playFieldVM;
        private int _x;

        public int X
        {
            get => _x;
        }

        public int Y
        {
            get => _y;
        }

        private int _y;

        public TileViewModel(PlayFieldViewModel _playFieldVM, int x, int y)
        {
            this._playFieldVM = _playFieldVM;
            this._x = x;    
            this._y = y;
        }

        public Color Color => _playFieldVM.GetTile(_x, _y).Color;
    }
}