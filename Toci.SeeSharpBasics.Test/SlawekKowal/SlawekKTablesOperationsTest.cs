using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal;

namespace Toci.SeeSharpBasics.Test.SlawekKowal
{
    [TestClass]
    public class SlawekKTablesOperationsTest
    {
        SlawekKTableOperations str = new SlawekKTableOperations();
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] tabb = new[] { 2, 1, 9, 4 };
            int[] tabb1 = new[] { 2, 1, 9, 2, 4, 2 };


            var test = str.BubbleSort(tabb);
            Assert.AreEqual(test[1], 2);
            Assert.AreEqual(test[2], 4);
            Assert.AreEqual(test[3], 9);
            var test1 = str.BubbleSort(tabb1);
            Assert.AreEqual(test1[1], 2);
            Assert.AreEqual(test1[2], 2);
            Assert.AreEqual(test1[3], 2);
        }
    }
}