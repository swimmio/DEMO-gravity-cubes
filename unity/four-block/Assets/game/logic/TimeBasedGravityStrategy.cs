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

        public void Update()
        {
            _gravityScale += _gravityIncreasePerSecond * Time.deltaTime;
        }
    }
}
