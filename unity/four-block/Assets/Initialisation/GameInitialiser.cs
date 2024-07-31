using game.logic;
using game.logic.EventQueue;
using game.logic.playfield;
using game.logic.tile;
using game.logic.tilespawner;
using game.service;
using gamerunner;
using UnityEngine;

public class GameInitialiser : MonoBehaviour
{
    public PlayFieldView PlayFieldPrefab;
    public TileView TilePrefab;

    public Dispatcher Dispatcher;
    
    void Start()
    {
        var serviceLocator = new ServiceLocator();
        
        var playField = new PlayField();
        var playFieldVM = new PlayFieldViewModel(playField, serviceLocator);
        
        var playFieldView = GameObject.Instantiate(PlayFieldPrefab);
        playFieldView.Link(playFieldVM);
        
        for (int x = 0; x < playFieldVM.Width; x++)
        {
            for (int y = 0; y < playFieldVM.Height; y++)
            {
                var tile = new Tile(Color.black);
                playFieldVM.PlaceTile(tile, x, y);
                
                var tileView = GameObject.Instantiate(TilePrefab, playFieldView.TileAnchor);
                tileView.Link(new TileViewModel(playFieldVM, x, y));
            }
        }
        var gravity = new GravityService();
        serviceLocator.RegisterService(gravity);

        var spawner = new TileSpawnerService();
        serviceLocator.RegisterService(spawner);
        
        var eventQueue = new EventQueue();
        serviceLocator.RegisterService(eventQueue);
        
        var gameRunner = new GameRunner(serviceLocator);
        Dispatcher.addUpdatable(gameRunner);
        Dispatcher.addUpdatable(gravity);
        Dispatcher.addUpdatable(playFieldVM);
        
        Destroy(this.gameObject);
    }
}
