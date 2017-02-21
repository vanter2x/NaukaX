using SeeSharpBasics.Training5.Chess;
using System.Windows.Forms;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class SlawekKFigure : Figure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess)
        {
            throw new System.NotImplementedException();
        }

       protected override bool CanOccupy(ChessField source, ChessField destination, bool isFinalField)
        {


            return false;
        }

        
    }
}