using System.Collections;
using System.Collections.Generic;
using game.logic;
using game.logic.EventQueue;
using game.logic.tile;
using game.logic.tilespawner;
using game.service;
using gamerunner;
using UnityEngine;

public class GameRunner : IUpdatable
{
    private ServiceLocator _serviceLocator;
    private float _gravitySum = 0.0f;
    private int frames = 0;
    
    public TileSpawnerService.CreateTileShapeDelegate CreateTileShape;

    public GameRunner(ServiceLocator serviceLocator)
    {
        _serviceLocator = serviceLocator;
    }

    public void Update()
    {
        var gravity = _serviceLocator.GetService<GravityService>();
        _gravitySum += gravity.CurrentGravity;
        frames++;
        if(_gravitySum > 100.0f)
        {
            var spawner = _serviceLocator.GetService<TileSpawnerService>();
            frames = 0;
            _gravitySum = 0.0f;
            if (CreateTileShape == null)
            {
                CreateTileShape = spawner.Spawn();    
            }
            
            var eventQueue = _serviceLocator.GetService<EventQueue>();
            eventQueue.Enqueue(new SpawnTileEvent(this, CreateTileShape));
            
            CreateTileShape = spawner.Spawn();
        }
    }
}
