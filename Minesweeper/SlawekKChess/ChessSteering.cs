using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SeeSharpBasics.SlawekKowal.Training5;
using SeeSharpBasics.Training5.Chess;

namespace Minesweeper.SlawekKChess
{
    public class ChessSteering
    {
        
        internal void ButtonSetup(Form form, ChessBoard chessBoard)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard.Chess[i, j].Size = new Size(60, 60);
                    chessBoard.Chess[i, j].Text = "";
                    chessBoard.Chess[i, j].Enabled = false;
                    chessBoard.Chess[i, j].FlatStyle = FlatStyle.Popup;
                    chessBoard.Chess[i, j].BackgroundImageLayout = ImageLayout.Center;
                    chessBoard.Chess[i, j].Location = new Point(i * 60, j * 60);
                    chessBoard.Chess[i, j].BackColor = chessBoard.Chess[i, j].Colour ? Color.WhiteSmoke : Color.Silver;
                    chessBoard.Chess[i, j].ForeColor = chessBoard.Chess[i, j].Colour ? Color.Silver : Color.WhiteSmoke;
                    chessBoard.Chess[i, j].Visible = true;
                    chessBoard.Chess[i, j].Tag = null;
                    form.Controls.Add(chessBoard.Chess[i, j]);
                }
            }
        }

        internal void ChessFieldEnabled(bool player, ChessBoard chessBoard)
        {
            foreach (var checker in chessBoard.Chess)
            {
                checker.Enabled = checker.Figure != null && checker.Figure.Colour == player;
            }
        }

        internal void ChessFieldEnabled(ChessBoard chessBoard)
        {
            foreach (var checker in chessBoard.Chess)
            {
                checker.Enabled = checker.Figure != null;
            }
        }

        internal void ChessFieldEnabled(ChessField oneChecker, ChessBoard chessBoard)
        {
            foreach (var checker in chessBoard.Chess)
            {
                checker.Enabled = checker == oneChecker;
            }
            //oneChecker.Enabled = true;
        }

        internal void ChessFieldColor(ChessField oneChecker, ChessBoard chessBoard)
        {
            foreach (var checker in chessBoard.Chess)
            {
                checker.BackColor = (checker.Enabled && checker != oneChecker) ? Color.Aquamarine : checker.BackColor;
            }
        }

        internal void ChessFieldColorBack(ChessBoard chessBoard)
        {
            foreach (var checker in chessBoard.Chess)
            {
                checker.BackColor = checker.Colour ? Color.WhiteSmoke : Color.Silver;
            }
        }



        internal void ButtonImageLoad( ChessBoard chessBoard)
        {
            foreach (var chessField in chessBoard.Chess)
            {
                if (chessField.Figure == null) continue;
                var fieldKey = chessField.Figure.Colour ? ("W"+ chessField.Figure.GetType().Name+".png") : ("B"+ chessField.Figure.GetType().Name+ ".png");
                chessField.BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/" + fieldKey);
            }
        }

        

        public void Check(ChessBoard chessBoard, bool player, out bool check)
        {
            
            chessBoard.Chess1.FindAll(mm=>mm.Figure!=null && mm.Figure.Colour!=player ).ForEach(mm => mm.Figure.CanOccupy(mm, chessBoard));
            //chessBoard.Chess1.FindAll(mm=>mm.Tag!=null).Any(mm=> check = true);
            check = chessBoard.Chess1.Any(mm => mm.Tag != null);

        }






        internal void ChessLoad(ChessBoard chessBrd)
        {
            for (int i = 0; i < 8; i++)
            {

                
                chessBrd.Chess[i, 1].Figure = new SPawn {Colour = false};
                chessBrd.Chess[i, 6].Figure = new SPawn { Colour = true };
                switch (i)
                {
                    case 0:
                    case 7:
                        chessBrd.Chess[i, 0].Figure = new SRook { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SRook { Colour = true };
                        break;
                    case 1:
                    case 6:
                        chessBrd.Chess[i, 0].Figure = new SKnight { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SKnight { Colour = true };
                        break;
                    case 2:
                    case 5:
                        chessBrd.Chess[i, 0].Figure = new SBishop { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SBishop { Colour = true };
                        break;
                    case 3:
                        chessBrd.Chess[i, 0].Figure = new SQueen { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SQueen { Colour = true };
                        break;
                    default:
                        chessBrd.Chess[i, 0].Figure = new SKing { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SKing { Colour = true };
                        break;
                }
            }
            //var c = chessBrd.Chess1.Select(field) .Where();
        }
    }
}