using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeeSharpBasics.SlawekKowal.Training3;

namespace Minesweeper
{
    public partial class SlawekKowal : Form
    {
        readonly SlawekKMineSweeper _minerSweeper = new SlawekKMineSweeper();
        private int[,] _map;
        private Button[,] _mineButton;
        private Button _helpBtn = new Button();
        const int BSize = 25;

        public SlawekKowal()
        {
            InitializeComponent();
        }

        protected void DrawButtons(int dimx, int dimy, int bombs)
        {
            _map = _minerSweeper.BombsCount(dimx, dimy, bombs);

            _mineButton = new Button[dimx, dimy];
            for (int i = 0; i < dimx; i++)
            {
                for (int j = 0; j < dimy; j++)
                {
                    _mineButton[i, j] = new Button();
                    ButtonSetup(_mineButton[i, j], i, j);
                }
            }
            Size = new Size(_mineButton[dimx - 1, 0].Left + BSize + 16, _mineButton[0, dimy - 1].Top + BSize + 40);
        }

        private void ButtonSetup(Button button, int destX, int destY)
        {
            button.Size = new Size(BSize, BSize);
            button.Text = "";
            button.Location = new Point(destX * BSize, destY * BSize + txt1.Top + txt1.Height + 15);
            button.Tag = _map[destX, destY].ToString();
            button.Visible = true;
            button.Click += Clicker;
            this.Controls.Add(button);
        }

        

        private void Clicker(object sender, EventArgs e)
        {
            _helpBtn = (Button)sender;
            _helpBtn.Text = _helpBtn.Tag.ToString();
        }



        private void btnStart_Click(object sender, EventArgs e)

        {
            if (_mineButton == null)
            {
                DrawButtons(int.Parse(txt1.Text), int.Parse(txt2.Text), int.Parse(txtBomb.Text));
                return;
            }
            foreach (var btn in _mineButton)
            {
                btn.Dispose();
            }
            DrawButtons(int.Parse(txt1.Text), int.Parse(txt2.Text), int.Parse(txtBomb.Text));

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (var btn in _mineButton)
            {
                btn.Text = btn.Tag.ToString() == "0" ? "" : btn.Tag.ToString();

            }
        }
    }
}
