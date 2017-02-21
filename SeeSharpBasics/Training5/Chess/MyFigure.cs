using System.Collections.Generic;
using SeeSharpBasics.SlawekKowal.Training5;

namespace SeeSharpBasics.Training5.Chess
{
    public class MyFigure : Figure
    {
        

        public override bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess)
        {
            chess.Chess[destX, destY].Figure = chess.Chess[srcX, srcY].Figure;
            chess.Chess[destX, destY].BackgroundImage = chess.Chess[srcX, srcY].BackgroundImage;
            chess.Chess[srcX, srcY].Figure = null;
            chess.Chess[srcX, srcY].BackgroundImage = null;

            return true;
        }
        
        public virtual void CanOccupy(ChessField chessField, ChessBoard chessBoard) { }

        protected bool FindField(int x1, int y1, ChessField source, ChessBoard helpChessBoard,List<ChessField> lista )
        {
            var checker = helpChessBoard.Chess[x1,y1];
            checker.Enabled = checker.Figure == null || (checker.Figure.Colour != source.Figure.Colour);
            if(checker.Enabled) lista.Add(checker);
            if (checker.Figure != null && !(checker.Figure is SKing && checker.Figure.Colour!=source.Figure.Colour)) return false;
            return true;
        }
    }
}