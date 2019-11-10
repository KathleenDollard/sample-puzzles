using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    public class BaseClass { }

    public class DerivedClass : BaseClass { }

    [TestClass]
    public class OverloadsWithInterfaceOrBase
    {
        [TestMethod]
        [TestCategory("Overloads")]
        public void OverloadsTest()
        {
            var derivedClass = new DerivedClass();
            var baseClass = new BaseClass();
            var derivedClassAsBase = derivedClass as BaseClass;

            //Assert.IsTrue(Test(derivedClass).StartsWith("??"));
            //Assert.IsTrue(Test(baseClass).StartsWith("??"));
            //Assert.IsTrue(Test(derivedClassAsBase).StartsWith("??"));
        }

        private string Test(BaseClass item) => "BaseClass version";
        private string Test(DerivedClass item) => "DerivedClass version";
    }
}
