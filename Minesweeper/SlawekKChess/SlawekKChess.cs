using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SeeSharpBasics.SlawekKowal.Training5;
using SeeSharpBasics.Training5.Chess;
using Bishop = SeeSharpBasics.SlawekKowal.Training5.SBishop;

namespace Minesweeper.SlawekKChess
{
    public partial class SlawekKChess : Form
    {
        private readonly ChessBoard _chessBoard = new ChessBoard();

        public struct player
        {
            public bool color ;
            public bool check;
        }

        private player gamer = new player();

        
        private bool _player;
        bool _check = false;
        private ChessField _sField = null;
        private ChessField _dField = null;
        readonly ChessSteering game = new ChessSteering();
        private bool Player
        {
            get { return _player; }
            set
            {
                _player = value;
                //gamer.color = _player;
                //gamer.check = false;
                button1.BackColor = _player ? Color.White : Color.Black;
            }
        }

        public SlawekKChess()
        {
            InitializeComponent();
        }

        private void SlawekKChess_Load(object sender, EventArgs e)
        {
            foreach (var chessField in _chessBoard.Chess) chessField.Click += Clicker;
            
            game.ChessLoad(_chessBoard);
            game.ButtonSetup(this, _chessBoard);
            game.ButtonImageLoad(_chessBoard);
            Player = true;
            gamer.color = true;
            gamer.check = false;
            game.ChessFieldEnabled(Player, _chessBoard);
        }

        private void Clicker(object sender, EventArgs e)
        {
            var helpBtn = (ChessField)sender;

            if (_sField == helpBtn)//jezeli klikniemy jeszcze raz ta sama figurę
            {
                game.ChessFieldEnabled(Player, _chessBoard);
                game.ChessFieldColorBack(_chessBoard);
                _sField = null;
                return;
            }

            if (_sField != null) // obsługa przeniesienia figury
            {
                _dField = helpBtn;
                _sField.Figure.Move(_sField.X - 1, _sField.Y - 1, _dField.X - 1, _dField.Y - 1, _chessBoard);
                
                _chessBoard.Chess1.ForEach(field=> field.Tag = null);
                

                label1.Text = _check.ToString();
                Player = !Player;
                game.Check(_chessBoard, Player, out gamer.check);
                game.ChessFieldColorBack(_chessBoard);
                game.ChessFieldEnabled(Player, _chessBoard);
                _sField = null;
                _dField = null;
                label1.Text = gamer.check.ToString();
                return;
            }

            if (_sField == null) _sField = helpBtn; // pierwsza klinieta figura i jej potenjalne ruchy
            
            _sField.BackColor = Color.BlueViolet;
            game.ChessFieldEnabled(_chessBoard);
            game.ChessFieldEnabled(helpBtn, _chessBoard);
            MyFigure figure = (MyFigure)helpBtn.Figure;
            figure.CanOccupy(helpBtn,_chessBoard);
            
            game.ChessFieldColor(helpBtn, _chessBoard);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //game.Check(_chessBoard,Player);
        }
    }
}
