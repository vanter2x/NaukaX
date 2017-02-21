using System.Collections;
using System.Collections.Generic;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class SKnight : MyFigure
    {
        public override void CanOccupy(ChessField source, ChessBoard helpChessBoard)
        {
            var x = source.X - 1;
            var y = source.Y - 1;
            
            Dictionary<int, KnightOccupyDelegates> delegates = new Dictionary<int, KnightOccupyDelegates>
            {
                {1, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt>=0 && yInt>=0 ,XDelegate = (minued) => minued - 1, YDelegate = (minued) => minued - 2} },
                {2, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt>=0 && yInt<=7 ,XDelegate = (minued) => minued - 1, YDelegate = (addend) => addend + 2} },
                {3, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt<=7 && yInt>=0 ,XDelegate = (addend) => addend + 1, YDelegate = (minued) => minued - 2} },
                {4, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt<=7 && yInt<=7 ,XDelegate = (addend) => addend + 1, YDelegate = (addend) => addend + 2} },
                {5, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt<=7 && yInt>=0 ,XDelegate = (addend) => addend + 2, YDelegate = (minued) => minued - 1} },
                {6, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt<=7 && yInt<=7 ,XDelegate = (addend) => addend + 2, YDelegate = (addend) => addend + 1} },
                {7, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt>=0 && yInt>=0 ,XDelegate = (minued) => minued - 2, YDelegate = (minued) => minued - 1} },
                {8, new KnightOccupyDelegates {BoolDelegate = (xInt,yInt) => xInt>=0 && yInt<=7 ,XDelegate = (minued) => minued - 2, YDelegate = (addend) => addend + 1} },
             };

            for (int i = 1; i < 9; i++)
            {
                if (!delegates[i].BoolDelegate(delegates[i].XDelegate(x), delegates[i].YDelegate(y))) continue;
                var helpDest = helpChessBoard.Chess[delegates[i].XDelegate(x), delegates[i].YDelegate(y)];
                helpDest.Enabled = (helpDest.Figure == null || source.Figure.Colour != helpDest.Figure.Colour);
                if (helpDest.Figure is SKing && helpDest.Figure.Colour != source.Figure.Colour) source.Tag = helpDest;
            }
        }
    }
}