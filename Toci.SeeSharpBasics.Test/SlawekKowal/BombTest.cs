using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.SlawekKowal;

namespace Toci.SeeSharpBasics.Test.SlawekKowal
{
    [TestClass]
    public class BombTest
    {
        [TestMethod]
        public void TestBomb()
        {
            int xx = 10;
            int yy = 15;
            SlawekKMineSweeper mineSweeper = new SlawekKMineSweeper();
            var x = mineSweeper.BombsCount(xx, yy);
            for (int i = 0; i < xx; i++)
            {
                for (int j = 0; j < yy; j++)
                {
                    if(x[i,j] != -1) Debug.Write(" " + x[i,j]);
                    else Debug.Write(x[i, j]);
                }
                Debug.WriteLine("");
            }
            int[] longMont = new[] { 1, 3, 5, 7, 8, 10, 11 };
            if (longMont.Contains(12)) Debug.WriteLine("true");
            else Debug.WriteLine("false");
        }
    }
}