namespace SeeSharpBasics.Training5.Chess
{
    public class Rook : Figure
    {
       
        public override bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess)
        {
            if (srcX == destX || srcY == destY)
            {
                if (srcX == destX)
                {
                    for (int i = srcY; i <= destY; i++)
                    {
                        CanOccupy(chess.Chess[srcX, i], chess.Chess[srcX, i + 1], destY == i + 1);
                    }
                }
            }

            return false;
        }
    }
}