
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class ZPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            Debug.Log("Z");
            return new Tile(Color.red);
        }
    }
}