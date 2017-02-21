namespace SeeSharpBasics.Training3.Homework
{
    public abstract class MineSweeper // **
    {
        public abstract int[,] BombsCount(int dimx, int dimy, int bombsNumber); // -1 bomba

        // 0 1 1 2 -1 1 0 0 0 

        // 0 0 -> 0 1 1 0 1 1  == -1 ++ 0 0 -> value
    }
}