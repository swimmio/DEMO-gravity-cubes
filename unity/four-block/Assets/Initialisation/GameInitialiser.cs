using game.logic;
using game.logic.playfield;
using game.logic.tile;
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
        var playField = new PlayField();
        var playFieldVM = new PlayFieldViewModel(playField);
        
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

        var serviceLocator = new ServiceLocator();
        var gravity = new GravityService();
        serviceLocator.RegisterService(gravity);
        
        var gameRunner = new GameRunner(serviceLocator);
        Dispatcher.addUpdatable(gameRunner);
        Dispatcher.addUpdatable(gravity);
        
        Destroy(this.gameObject);
    }
}
