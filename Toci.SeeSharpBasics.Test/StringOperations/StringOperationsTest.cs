using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.SeeSharpBasics.Test.Common;

namespace Toci.SeeSharpBasics.Test.StringOperations
{
    [TestClass]
    public class StringOperationsTest
    {
        [TestMethod]
        public void AllStringOperationsTest()
        {
            AssemblyLoader loader = new AssemblyLoader();

            var allOperaions = loader.GetTypesInstancesList<global::SeeSharpBasics.StringOperations>();

            foreach (var stringOperations in allOperaions)
            {
                var name = stringOperations.GetName();
            }
        }

        
    }
}