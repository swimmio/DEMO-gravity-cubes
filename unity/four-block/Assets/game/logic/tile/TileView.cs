using UnityEngine;

namespace game.logic.tile
{
    public class TileView : MonoBehaviour
    {
        public SpriteRenderer TileSprite;
        
        private TileViewModel _tileVM;

        private void Start()
        {
        }
        
        public void Link(TileViewModel tileVM)
        {
            _tileVM = tileVM;
            this.transform.position = new Vector3(tileVM.X, tileVM.Y, 0);
        }

        void Update()
        {
            // Update the view based on the _tileVM here
        }
    }
}
