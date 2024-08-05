using gamerunner;
using UnityEngine;

namespace game.logic
{
    public class TimeBasedGravityStrategy : IUpdatable, IGravityStrategy
    {
        private float _gravityBase = 9.8f;
        private float _gravityScale = 1.0f;
        private float _gravityIncreasePerSecond = 0.1f;
    
        public float CurrentGravity => _gravityBase * _gravityScale;
        
        /// <summary>
        /// Updates the gravity scale based on the elapsed time.
        /// </summary>
        public void Update()
        {
            setGravityScale(_gravityScale + _gravityIncreasePerSecond * Time.deltaTime);
        }
        
        /// <summary>
        /// Sets the current level.
        /// </summary>
        /// <param name="level">The level to set.</param>
        public void setGravityScale(float gravityScale)
        {
            _gravityScale = gravityScale;
        }
    }
}
