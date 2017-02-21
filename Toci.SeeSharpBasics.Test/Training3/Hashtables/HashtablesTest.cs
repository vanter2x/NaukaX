using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Hashmaps;

namespace Toci.SeeSharpBasics.Test.Training3.Hashtables
{
    [TestClass]
    public class HashtablesTest
    {
        [TestMethod]
        public void Test()
        {
            HashmapExample example = new HashmapExample();

            Hashtable result = example.GetCharactersCount("ftgwsegsfdhdfhjdgjfgtyetrge");

        }
    }
}