
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class IPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            Debug.Log("I");
            return new Tile(Color.cyan);
        }
    }
}