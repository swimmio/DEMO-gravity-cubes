
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class TPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            return new Tile(Color.magenta);
        }
    }
}