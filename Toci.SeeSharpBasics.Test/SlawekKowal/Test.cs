using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.SlawekKowal;

namespace Toci.SeeSharpBasics.Test.SlawekKowal
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Tester()
        {
            //SlawekKCodeGenerator gen = new SlawekKCodeGenerator();
            

            SlawekKBankResolver bres = new SlawekKBankResolver();
            var xx= bres.GetBankName(bres.GetBankCodeForAccount("322130123123123123"));
            
            Debug.WriteLine(xx);
            
        }

        [TestMethod]
        public void Tester2()
        {
            //SlawekKCodeGenerator gen = new SlawekKCodeGenerator();


            SlawekKMoneyValue  gen = new SlawekKMoneyValue();
            var cc = gen.GetMoneyValue("53453534");

            Debug.WriteLine(cc);

        }

    }
}