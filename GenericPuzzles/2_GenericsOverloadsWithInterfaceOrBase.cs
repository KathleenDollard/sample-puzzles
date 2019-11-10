using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    public class BaseClass2
    { }

    public class DerivedClass2 : BaseClass2 { }

    [TestClass]
    public class GenericOverloadsWithInterfaceOrBase
    {
        [TestMethod]
        [TestCategory("Generics")]
        [TestCategory("Overloads")]
        public void GenericOverloadsTest()
        {
            var x = new DerivedClass2();
            GenericMethod<DerivedClass2, DerivedClass2>(x, x);
        }

        private void GenericMethod<T1, T2>(T1 first, T2 withConstraint)
            where T2 : BaseClass2
            where T1 : T2
        {
            T2 withCast = (T2)first;

            //Assert.IsTrue(Test(first).StartsWith("??"));
            //Assert.IsTrue(Test(withConstraint).StartsWith("??"));
            //Assert.IsTrue(Test(withCast).StartsWith("??"));
        }

        private string Test(BaseClass2 item) => "BaseClass version";
        private string Test(DerivedClass2 item) => "DerivedClass version";
    }
}
