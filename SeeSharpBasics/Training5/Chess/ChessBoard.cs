using System.Collections.Generic;

namespace SeeSharpBasics.Training5.Chess
{
    public class ChessBoard
    {
        public ChessField[,] Chess = new ChessField[8,8];
        public List<ChessField> Chess1= new List<ChessField>();
        public ChessBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Chess[i, j] = new ChessField
                    {
                        X = i + 1,
                        Y = j + 1,
                        Colour = (i + j)%2 == 1
                    };
                    Chess1.Add(Chess[i,j]);
                }
            }
        }
    }
}