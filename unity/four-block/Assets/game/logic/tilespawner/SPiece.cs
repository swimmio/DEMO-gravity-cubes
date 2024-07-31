
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class SPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            Debug.Log("S");
            return new Tile(Color.green);
        }
    }
}