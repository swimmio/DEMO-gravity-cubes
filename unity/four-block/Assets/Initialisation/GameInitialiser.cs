using game.logic.playfield;
using game.logic.tile;
using UnityEngine;

public class GameInitialiser : MonoBehaviour
{
    public PlayFieldView PlayFieldPrefab;
    public TileView TilePrefab;
    
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
        
        
        
        
        
        Destroy(this.gameObject);
    }
}
