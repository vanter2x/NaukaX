using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SeeSharpBasics.SlawekKowal.Training5;
using SeeSharpBasics.Training5.Chess;

namespace Minesweeper.SlawekKChess
{
    public class ChessStearing
    {
        

        internal void ButtonSetup(Form form, ChessBoard chessBoard)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard.Chess[i, j].Size = new Size(60, 60);
                    chessBoard.Chess[i, j].Text = "";
                    chessBoard.Chess[i,j].Enabled = false;
                    //if(j<=1)chessBoard.Chess[i, j].Enabled = true;  //test
                    chessBoard.Chess[i, j].FlatStyle = FlatStyle.Popup;
                    chessBoard.Chess[i, j].BackgroundImageLayout = ImageLayout.Center;
                    chessBoard.Chess[i, j].Location = new Point(i * 60, j * 60);
                    chessBoard.Chess[i, j].BackColor = chessBoard.Chess[i, j].Colour ? Color.WhiteSmoke : Color.Silver;
                    chessBoard.Chess[i, j].ForeColor = chessBoard.Chess[i, j].Colour ? Color.Silver : Color.WhiteSmoke;
                    chessBoard.Chess[i, j].Visible = true;
                    chessBoard.Chess[i, j].Tag = chessBoard.Chess[i, j].BackColor;
                    // chessBoard.Chess[i,j].Text = (i) + "," + (j);
                    //chessBoard.Chess[i,j].Click += Clicker;
                    // chessBoard.Chess.g
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
                checker.Enabled = checker.Figure != null ;
            }
        }

        internal void ChessFieldEnabled(ChessField oneChecker,ChessBoard chessBoard)
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
                checker.BackColor = (Color)checker.Tag;
            }
        }


        

        internal void che(ChessBoard chessBoard, bool player)
        {
             List<ChessField> xxx = new List<ChessField>();
            foreach (var helpBtn in chessBoard.Chess)
            {
                if (helpBtn.Figure == null || helpBtn.Figure.Colour == player) continue;
                
                
                xxx.Add(helpBtn);
                
                switch (helpBtn.Figure.GetType().Name)
                {

                    case "Bishop":
                        SlawekKowalMove.CanMoveDiagonally(helpBtn, chessBoard);
                        break;
                    case "Pawn":
                        SlawekKowalMove.MovePawn(helpBtn, chessBoard);
                        break;
                    case "Knight":
                        SlawekKowalMove.MoveKnight(helpBtn, chessBoard);
                        break;
                    case "Queen":
                        SlawekKowalMove.CanMoveVerHor(helpBtn, chessBoard);
                        SlawekKowalMove.CanMoveDiagonally(helpBtn, chessBoard);
                        break;
                    case "King":
                        SlawekKowalMove.MoveKing(helpBtn, chessBoard);
                        break;
                    case "Rook":
                        SlawekKowalMove.CanMoveVerHor(helpBtn, chessBoard);
                        break;
                }
                ChessFieldColor(helpBtn, chessBoard);
                
            }
            foreach(var cc in xxx) ChessFieldEnabled(cc, chessBoard);
            

        }


        internal void ButtonImageLoad(ChessBoard chessBoard)
        {
            for (int i = 0; i < 8; i++)
            {
                chessBoard.Chess[i, 1].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/bp.png");
                chessBoard.Chess[i, 6].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/wp.png");
                switch (i)
                {
                    case 0:
                    case 7:
                        chessBoard.Chess[i, 0].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/br.png");
                        chessBoard.Chess[i, 7].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/wr.png");
                        break;
                    case 1:
                    case 6:
                        chessBoard.Chess[i, 0].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/bn.png");
                        chessBoard.Chess[i, 7].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/wn.png");
                        break;
                    case 2:
                    case 5:
                        chessBoard.Chess[i, 0].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/bb.png");
                        chessBoard.Chess[i, 7].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/wb.png");
                        break;
                    case 3:
                        chessBoard.Chess[i, 0].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/bq.png");
                        chessBoard.Chess[i, 7].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/wq.png");
                        break;
                    default:
                        chessBoard.Chess[i, 0].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/bk.png");
                        chessBoard.Chess[i, 7].BackgroundImage = Image.FromFile("../../SlawekKChess/ChessImg/wk.png");
                        break;
                }
            }
        }

        
        internal void ChessLoad(ChessBoard chessBrd)
        {
            for (int i = 0; i < 8; i++)
            {
                chessBrd.Chess[i, 1].Figure = new SeeSharpBasics.SlawekKowal.Training5.Pawn { Colour = false };
                chessBrd.Chess[i, 6].Figure = new SeeSharpBasics.SlawekKowal.Training5.Pawn { Colour = true };
                switch (i)
                {
                    case 0:
                    case 7:
                        chessBrd.Chess[i, 0].Figure = new SeeSharpBasics.SlawekKowal.Training5.Rook { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SeeSharpBasics.SlawekKowal.Training5.Rook { Colour = true };
                        break;
                    case 1:
                    case 6:
                        chessBrd.Chess[i, 0].Figure = new SeeSharpBasics.SlawekKowal.Training5.Knight { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SeeSharpBasics.SlawekKowal.Training5.Knight { Colour = true };
                        break;
                    case 2:
                    case 5:
                        chessBrd.Chess[i, 0].Figure = new SeeSharpBasics.SlawekKowal.Training5.Bishop { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SeeSharpBasics.SlawekKowal.Training5.Bishop { Colour = true };
                        break;
                    case 3:
                        chessBrd.Chess[i, 0].Figure = new SeeSharpBasics.SlawekKowal.Training5.Queen { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SeeSharpBasics.SlawekKowal.Training5.Queen { Colour = true };
                        break;
                    default:
                        chessBrd.Chess[i, 0].Figure = new SeeSharpBasics.SlawekKowal.Training5.King { Colour = false };
                        chessBrd.Chess[i, 7].Figure = new SeeSharpBasics.SlawekKowal.Training5.King { Colour = true };
                        break;
                }
            }

        }
    }
}