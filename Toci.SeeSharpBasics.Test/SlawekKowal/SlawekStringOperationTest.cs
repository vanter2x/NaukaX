using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal;

namespace Toci.SeeSharpBasics.Test.SlawekKowal
{
    [TestClass]
    public class SlawekStringOperationTest
    {
        SlawekKStringOperations str = new SlawekKStringOperations();
        
        [TestMethod]
        public void ReplaceTest()
        {
            string text = "blabla-123-bla-12";
            string text1 = "blabla-123-bla-";
            string text2 = "blabla-123-bla-1";
            string text3 = "blabla-123-bla";

            var test = str.StringReplace(text, "bla", "ok");
            Assert.AreEqual(test, "okok-123-ok-12");
            test = str.StringReplace(text1, "bla", "ok");
            Assert.AreEqual(test, "okok-123-ok-");
            test = str.StringReplace(text2, "bla", "ok");
            Assert.AreEqual(test, "okok-123-ok-1");
            test = str.StringReplace(text3, "bla", "ok");
            Assert.AreEqual(test, "okok-123-ok");
        }

        [TestMethod]
        public void GlueTest()
        {
            var test = str.GlueBeginingEnd("beata");
            Assert.AreEqual(test, "baeta");
            test = str.GlueBeginingEnd("beatka");
            Assert.AreEqual(test, "baekat");
        }

        [TestMethod]
        public void ReverseTest()
        {
            var test = str.StringReverse("Beata");
            Assert.AreEqual(test, "ataeB");
            test = str.StringReverse("Slawek");
            Assert.AreEqual(test, "kewalS");
        }
    }
}