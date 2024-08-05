using System;

namespace game.logic
{
    public interface IGravityStrategy
    {
        
        [Obsolete("This method is obsolete. Use Gravity instead.")]
        public float CurrentGravity { get; }
        
        public float Gravity { get; }
    }
}