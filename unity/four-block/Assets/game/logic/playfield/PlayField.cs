using game.logic.tile;

namespace game.logic.playfield
{
    public class PlayField
    {
        private const int FieldWidth = 10;
        private const int FieldHeight = 22;

        public int Width => FieldWidth;
        public int Height => FieldHeight;

        public ITileable[,] Field = new ITileable[FieldWidth, FieldHeight];
    
    }
}
