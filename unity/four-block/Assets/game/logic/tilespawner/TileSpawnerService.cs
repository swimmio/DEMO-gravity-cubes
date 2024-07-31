using System;
using System.Collections.Generic;
using System.Linq;
using game.service;
using Unity.VisualScripting;
using Random = System.Random;

namespace game.logic.tilespawner
{
    public class TileSpawnerService: IService
    {
        public delegate ISpawnable CreateTileShapeDelegate();
        
        List<CreateTileShapeDelegate> _pieces = new List<CreateTileShapeDelegate>{
            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece
        };

        public TileSpawnerService()
        {
            Shuffle();
        }

        private static ISpawnable SpawnIPiece() => new IPiece();
        private static ISpawnable SpawnJPiece() => new JPiece();
        private static ISpawnable SpawnLPiece() => new LPiece();
        private static ISpawnable SpawnOPiece() => new OPiece();
        private static ISpawnable SpawnSPiece() => new SPiece();
        private static ISpawnable SpawnTPiece() => new TPiece();
        private static ISpawnable SpawnZPiece() => new ZPiece();

        public CreateTileShapeDelegate Spawn()
        {
            Shuffle();
            return _pieces.First();
        }

        private Random rng = new Random();
        private void Shuffle()  
        {  
            var n = _pieces.Count;  
            while (n > 1) {  
                n--;  
                var k = rng.Next(n + 1);  
                (_pieces[k], _pieces[n]) = (_pieces[n], _pieces[k]);
            }  
        }
    }
}