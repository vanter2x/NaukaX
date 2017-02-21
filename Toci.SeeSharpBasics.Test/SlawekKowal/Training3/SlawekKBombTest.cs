using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal.Training3;
using System.Linq;

namespace Toci.SeeSharpBasics.Test.SlawekKowal.Training3
{
    [TestClass]
    public class SlawekKBombTest
    {
        [TestMethod]
        public void TestBomb()
        {
            int xx = 10;
            int yy = 15;
            SlawekKMineSweeper mineSweeper = new SlawekKMineSweeper();
            var x = mineSweeper.BombsCount(xx, yy, 20);
            for (int i = 0; i < xx; i++)
            {
                for (int j = 0; j < yy; j++)
                {
                    if (x[i, j] != -1) Debug.Write(" " + x[i, j]);
                    else Debug.Write(x[i, j]);
                }
                Debug.WriteLine("");
            }
            
        }
    }
}