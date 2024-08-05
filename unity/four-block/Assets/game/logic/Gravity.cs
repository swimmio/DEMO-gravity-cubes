using gamerunner;
using UnityEngine;

namespace game.logic
{
    public class GravityService : IUpdatable, IGravityService
    {
        private IGravityStrategy _gravityStrategy;

        public float CurrentGravity => _gravityStrategy.CurrentGravity;

        public GravityService(IGravityStrategy gravityStrategy)
        {
            _gravityStrategy = gravityStrategy;
        }

        public void Update()
        {
            if (_gravityStrategy is IUpdatable updatable)
            {
                updatable.Update();
            }
        }
    }
}
