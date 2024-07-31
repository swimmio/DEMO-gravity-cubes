using System;
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class JPiece: ISpawnable
    {
        public ITileable Spawn()
        {
            Debug.Log("J");
            return new Tile(Color.blue);
        }
    }
}