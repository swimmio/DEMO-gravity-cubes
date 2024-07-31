
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class OPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            Debug.Log("O");
            return new Tile(Color.yellow);
        }
    }
}