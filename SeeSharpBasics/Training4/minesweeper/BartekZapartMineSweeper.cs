using System;
using System.Diagnostics;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.Training4.minesweeper
{
    public class BartekZapartMineSweeper : MineSweeper
    {
        private const int bomb = -1;

        public override int[,] BombsCount(int dimx, int dimy, int bombsNumber)
        {
            int[,] bombsMap = new int[dimx,dimy];

            int randomX = 0;
            int randomY = 0;

            Random rnd = new Random(DateTime.Now.Millisecond);

            while (bombsNumber > 0)
            {
                randomX = rnd.Next(0, dimx - 1);
                randomY = rnd.Next(0, dimy - 1);

                if (bombsMap[randomX, randomY] != bomb)
                {
                    bombsMap[randomX, randomY] = bomb;
                    bombsNumber--;
                }
            }

            bombsMap = CountBombs(bombsMap);

            return bombsMap;
        }

        private int[,] CountBombs(int[,] bombsMap)
        {
            for (int i = 0; i < bombsMap.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < bombsMap.GetLength(1) - 1; j++)
                {
                    if (bombsMap[i, j] == bomb)
                        continue;

                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i - 1, j - 1)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i - 1, j)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i - 1, j + 1)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i, j - 1)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i, j + 1)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i + 1, j - 1)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i + 1, j)) bombsMap[i, j]++;
                    if (BombExists(bombsMap, bombsMap.GetLength(0), bombsMap.GetLength(1), i + 1, j + 1)) bombsMap[i, j]++;
                }
            }

            return bombsMap;
        }

        private bool BombExists(int[,] bombsMap, int dimx, int dimy, int requestedDimX, int requestedDimY)
        {
            if (requestedDimX < 0 || requestedDimY < 0) return false;
            if (requestedDimX >= dimx || requestedDimY >= dimy) return false;

            if (bombsMap[requestedDimX, requestedDimY] == bomb) return true;

            return false;
        }

        public void Show(int[,] bombsMap)
        {
            for (int i = 0; i < bombsMap.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < bombsMap.GetLength(1) - 1; j++)
                {
                    if (bombsMap[i, j] == bomb)
                        Console.Write("{0} ", bombsMap[i, j]);
                    else
                        Console.Write(" {0} ", bombsMap[i,j]);
                }

                Console.WriteLine("");
            }
        }
    }
}