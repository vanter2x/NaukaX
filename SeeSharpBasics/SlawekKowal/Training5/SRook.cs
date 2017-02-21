using System.Collections.Generic;
using System.Linq;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class SRook : MyFigure
    {
        protected List<ChessField>[] lists = new List<ChessField>[4]
        {
            new List<ChessField>(),
            new List<ChessField>(),
            new List<ChessField>(),
            new List<ChessField>(),
        };

        public override void CanOccupy(ChessField source, ChessBoard helpChessBoard)
        {
            int x = source.X - 1;
            int y = source.Y - 1;
            lists.ToList().ForEach(mm=> mm.Clear());
            var cc = 3;
            for (int i = y - 1; i >= 0; i--)
            {
                if (!FindField(x, i, source, helpChessBoard, lists[0])) break;
                //lists[0].Add(helpChessBoard.Chess[x, i]);
            }
            for (int i = x - 1; i >= 0; i--)
            {
                if (!FindField(i, y, source, helpChessBoard, lists[1])) break;
                //lists[1].Add(helpChessBoard.Chess[i, y]);
            }
            for (int i = y + 1; i <= 7; i++)
            {
                if (!FindField(x, i, source, helpChessBoard, lists[2])) break;
                //lists[2].Add(helpChessBoard.Chess[x, i]);
            }
            for (int i = x+1 ; i <= 7; i++)
            {
                if (!FindField(i, y, source, helpChessBoard, lists[3])) break;
               // lists[3].Add(helpChessBoard.Chess[i, y]);
            }

            foreach (var lista in lists) if(lista.Any(lst => lst.Figure is SKing)) source.Tag = lista.ToList();
        }
    }
}