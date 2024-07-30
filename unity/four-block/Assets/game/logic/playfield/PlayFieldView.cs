using UnityEngine;

namespace game.logic.playfield
{
    public class PlayFieldView : MonoBehaviour
    {
        public Transform TileAnchor;
        
        private PlayFieldViewModel _playFieldVM;

        private void Start()
        {
        }
        
        public void Link(PlayFieldViewModel playFieldVM)
        {
            _playFieldVM = playFieldVM;
        }

        void Update()
        {
        
        }
    }
}
