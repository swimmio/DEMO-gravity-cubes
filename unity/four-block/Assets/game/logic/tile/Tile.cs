using UnityEngine;

namespace game.logic.tile
{
    public class Tile: ITileable
    {
        public Tile(Color color)
        {
            Color = color;
        }

        public Color Color { get; }
    }
}