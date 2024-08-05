using gamerunner;
using UnityEngine;

namespace game.logic
{
    public class LevelBasedGravityStrategy : IGravityStrategy
    {
        private readonly float _gravityBase = 9.8f;
        private int _level = 1;
        private const float GravityIncreasePerLevel = 0.75f;
    
        public float CurrentGravity => _gravityBase * _level;

        public void SetLevel(int level)
        {
            _level = level;
        }
        
        public void LevelUp()
        {
            _level++;
        }
        
        public void ResetLevel()
        {
            _level = 1;
        } 
    }
}
