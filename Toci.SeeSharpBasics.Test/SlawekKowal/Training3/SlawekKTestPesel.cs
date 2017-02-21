using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal.Training3;

namespace Toci.SeeSharpBasics.Test.SlawekKowal.Training3
{
    [TestClass]
    public class SlawekKTestPesel
    {
        [TestMethod]
        public void PeselTest()
        {
            SlawekKPeselValidator pslVal = new SlawekKPeselValidator();
            var x = pslVal.IsPeselValid("84100815397");
            var y = pslVal.IsPeselValid("14271012387");
            var a = pslVal.GetYear(84, 10);
            var b = pslVal.GetMonth(10);
            var c = pslVal.ChechMonth(10);
            var d = pslVal.CheckDays(a, b, 8);
            Debug.WriteLine(x.ToString());
            Debug.WriteLine(y.ToString());
            Debug.WriteLine("koniec");
        }
    }
}