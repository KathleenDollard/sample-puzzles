using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    // Difference is in the additional parameter, then make it optional
    public class BaseClass5
    { public string Foo(Int16 x) => "BaseClass";
    }
    public class DerivedClass5 : BaseClass5
    { public string Foo(Int32 x, bool b) => "DerivedClass";
    }
    [TestClass]
    public class OverloadsAndInheritanceA
    {
        [TestMethod]
        public void Test()
        {
            Int16 x = 42;
            var obj = new DerivedClass3();
            var result = obj.Foo(x);
            //Assert.AreEqual("??", result);
        }

    }
}
