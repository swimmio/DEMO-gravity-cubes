using game.logic.tile;

namespace game.logic.tilespawner
{
    public interface ISpawnable
    {
        ITileable Spawn();
    }
}