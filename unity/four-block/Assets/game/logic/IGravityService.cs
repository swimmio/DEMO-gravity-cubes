using game.service;

namespace game.logic
{
    public interface IGravityService: IService
    {
        public float CurrentGravity { get; }
    }
}