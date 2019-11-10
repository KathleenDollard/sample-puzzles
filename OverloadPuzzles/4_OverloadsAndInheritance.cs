using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    public class BaseClass3
    { public string Foo(Int16 x) => "BaseClass";}
    public class DerivedClass3 : BaseClass3
    { public string Foo(Int32 x) => "DerivedClass";
    }
    [TestClass]
    public class OverloadsAndInheritance
    {
        [TestMethod]
        public void Test()
        {
            Int16 x = 42;
            var obj = new DerivedClass3();
            var obj2 = obj as BaseClass3;
            var result = obj2.Foo(x);
            //Assert.AreEqual("??", result);
        }
    }
    
}
