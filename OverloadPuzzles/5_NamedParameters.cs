using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace methods_and_overloads
{
    [TestClass]
    public class NamedParameters
    {
        [TestMethod]
        public void TestMethod1()
        {
            var b1 = new B1();
            //Assert.AreEqual("??", b1.F(42));
            //Assert.AreEqual("??", b1.F(George: 42));
            //Assert.AreEqual("??", b1.F(Fred: 42));
        }

        public class A1
        {
            public virtual string F(int Fred)
                => "Base Foo";
        }

        public class B1 : A1
        {
            public override string F(int George)
                => "Derived Foo";
        }
    }
}
