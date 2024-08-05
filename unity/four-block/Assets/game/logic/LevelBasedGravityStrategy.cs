using System;
using gamerunner;
using UnityEngine;

namespace game.logic
{
    [Serializable]
    public class LevelBasedGravityStrategy : IGravityStrategy
    {
        private readonly float _gravityBase = 9.8f;
        private int _level = 1;
        private const float GravityIncreasePerLevel = 0.75f;
    
        public float CurrentGravity => _gravityBase * _level;
        public float Gravity => _gravityBase * _level;

        /// <summary>
        /// Sets the current level.
        /// </summary>
        /// <param name="level">The level to set.</param>
        public void SetLevel(int level)
        {
            _level = level;
        }
        
        /// <summary>
        /// Increases the level by one.
        /// </summary>
        public void LevelUp()
        {
            _level++;
        }
        
        /// <summary>
        /// resets the level to 1.
        /// </summary>
        public void ResetLevel()
        {
            _level = 1;
        } 
    }
}
