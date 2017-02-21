using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.SlawekKowal;

namespace Toci.SeeSharpBasics.Test.SlawekKowal
{
    [TestClass]
    public class TestPesel
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
            var d = pslVal.CheckDays(a,b,8);
            Debug.WriteLine(x.ToString());
            Debug.WriteLine(y.ToString());
            Debug.WriteLine("koniec");
        }
    }
}