using System;

namespace SeeSharpBasics.Training3.Homework.SlawekKowal
{
    public class SlawekKMineSweeper: MineSweeper
    {
        //private int[,] mineBoard;
        private Random rnd = new Random();   // losowe liczby
        private int bombCount = 0;           // ilość bomb
        public override int[,] BombsCount(int dimx, int dimy)
        {
            int[,] tB = new int[dimx,dimy];  // tablica tymczasowa
            int x, y;                        // zmienne do losowania pól z bombami
            bombCount = 10;                  // ustawienie ilości bomb;

            // 1.wypełnienie tablicy zerami
            for (int i = 0; i < dimx; i++)
            {
                for (int j = 0; j < dimy; j++)
                {
                    tB[i, j] = 0;
                }
            } //koniec 1.
            

            // 2. losowanie 10 pól i przypisanie im bomb(-1)
            while (bombCount>0)
            {
                x = rnd.Next(0, dimx - 1);
                y = rnd.Next(0, dimy - 1);
                if (tB[x,y] == 0)
                {
                    tB[x, y] = -1;
                    bombCount--;
                }
            } //koniec 2.

            //3, zliczanie ilości bomb w sąsiednich polach
            for (int i = 0; i < dimx; i++)
                for (int j = 0; j < dimy; j++)
                    for (int ii = i - 1; ii <= i + 1; ii++)
                        if ((ii >= 0) && (ii < dimx))
                            for (int jj = j - 1; jj <= j + 1; jj++)
                            {
                                if ((jj >= 0) && (jj < dimy) && tB[ii, jj] == -1)
                                    if (tB[i, j] != -1) tB[i, j] += 1;
                            }





            return tB;
        }
    }
}