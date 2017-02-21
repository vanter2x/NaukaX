using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class SKing : MyFigure
    {
        private List<ChessField> kingList = new List<ChessField>();
        public override void CanOccupy(ChessField source, ChessBoard helpChessBoard)
        {
            kingList.Clear();
            for (int i = source.X - 2; i < source.X + 1; i++)
            {
                for (int j = source.Y - 2; j < source.Y + 1; j++)
                {
                    if (i >= 0 && i < 8 && j >= 0 && j < 8)
                    {
                        var helpDest = helpChessBoard.Chess[i, j];
                        if(helpDest.Figure is SKing || helpDest.Figure == null || source.Figure.Colour != helpDest.Figure.Colour) kingList.Add(helpDest);
                    }
                }
            }
            KingMove(source,helpChessBoard,kingList);
        }

        private void KingMove(ChessField source,ChessBoard chessBoard, List<ChessField> list)
        {
            var xxx= chessBoard.Chess1.FindAll(field =>(field.Figure != null && !(field.Figure is SKing)  && field.Figure.Colour != source.Figure.Colour)).ToList();
                //xxx.ForEach(field => MessageBox.Show(field.Figure.GetType().Name));
               foreach(var cc in xxx) cc.Figure.CanOccupy(cc,chessBoard);
            var enemyList = chessBoard.Chess1.Where(field => field.Enabled).ToList();
            list.ForEach(field=> field.Enabled=true);
            enemyList.ForEach(field=> field.Enabled = false);
            source.Enabled = true;
        }

    }
}