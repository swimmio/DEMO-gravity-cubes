using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class LPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            Debug.Log("L");
            return new Tile(new Color(1f, 0.5f, 0f));
        }
    }
}