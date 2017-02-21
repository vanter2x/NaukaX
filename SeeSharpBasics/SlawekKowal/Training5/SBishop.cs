
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class SBishop : MyFigure
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
            //foreach (var list in lists) list.Clear();
            lists.ToList().ForEach(mm => mm.Clear());
            int x = source.X - 1;
            int y = source.Y - 1;
           
            for (int x1 = x - 1, y1 = y - 1; x1 >= 0 && y1 >= 0; x1--, y1--)
            {
                if (!FindField(x1, y1, source, helpChessBoard,lists[0])) break;
               
            }
            for (int x1 = x + 1, y1 = y - 1; x1 <= 7 && y1 >= 0; x1++, y1--)
            {
                if (!FindField(x1, y1, source, helpChessBoard, lists[1])) break;
               // lists[1].Add(helpChessBoard.Chess[x1, y1]);
            }
            for (int x1 = x - 1, y1 = y + 1; x1 >= 0 && y1 <= 7; x1--, y1++)
            {
                if (!FindField(x1, y1, source, helpChessBoard, lists[2])) break;
               // lists[2].Add(helpChessBoard.Chess[x1, y1]);
            }
            for (int x1 = x + 1, y1 = y + 1; x1 <= 7 && y1 <= 7; x1++, y1++)
            {
                if (!FindField(x1, y1, source, helpChessBoard, lists[3])) break;
               // lists[3].Add(helpChessBoard.Chess[x1, y1]);
            }

            foreach (var lista in lists) if (lista.Any(lst => lst.Figure is SKing)) source.Tag = lista.ToList();
            if (source.Figure is SQueen)
            {
                var c = new SRook();
                c.CanOccupy(source,helpChessBoard);
            }
            if (source.Tag != null)
            {
                var xx=2;
            }

        }
    }
}