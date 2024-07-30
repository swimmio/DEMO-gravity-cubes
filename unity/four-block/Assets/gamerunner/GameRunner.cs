using System.Collections;
using System.Collections.Generic;
using game.logic;
using game.logic.tile;
using game.service;
using gamerunner;
using UnityEngine;

public class GameRunner : IUpdatable
{
    private ServiceLocator _serviceLocator;
    private float _gravitySum = 0.0f;
    private int frames = 0;
    
    //public delegate Tile CreateAndPlaceTileDelegate(int x, int y, Color color);

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
            frames = 0;
            _gravitySum = 0.0f;
            //CreateAndPlaceTileDelegate(0, 0, Color.green);
        }
    }
}
