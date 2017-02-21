using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class SPawn : MyFigure
    {
        public override void CanOccupy(ChessField source, ChessBoard helpChessBoard)
        {
            int x = source.X - 1;
            int y = source.Y - 1;
            var b = source.Figure.Colour ? y + 1 : 7;
            var c = source.Figure.Colour ? 6 : 1;

            if (y == c)
            {
                c = source.Figure.Colour ? -1 : 1;
                if(helpChessBoard.Chess[x, y + c].Figure!=null) helpChessBoard.Chess[x, y + c].Enabled = true;
                if (helpChessBoard.Chess[x, y + c].Figure == null && helpChessBoard.Chess[x, y + 2 * c].Figure == null) helpChessBoard.Chess[x, y + 2 * c].Enabled = true;
            }
            c = source.Figure.Colour ? 0 : y - 1;
            if (c < b)
            {
                c = source.Figure.Colour ? -1 : 1;
                var helpDest = helpChessBoard.Chess[x, y + c].Figure;
                helpChessBoard.Chess[x, y + c].Enabled = helpDest == null;

                helpDest = x > 0 ? helpChessBoard.Chess[x - 1, y + c].Figure : null;
                if (helpDest != null) helpChessBoard.Chess[x - 1, y + c].Enabled = x - 1 >= 0 && helpDest.Colour != source.Figure.Colour;

                helpDest = x < 7 ? helpChessBoard.Chess[x + 1, y + c].Figure : null;
                if (helpDest != null) helpChessBoard.Chess[x + 1, y + c].Enabled = x + 1 < 8 && helpDest.Colour != source.Figure.Colour;
            }
        }


    }
}