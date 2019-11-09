using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    public class BaseClass2
    {
        public string Foo(short bar)
        { return "Short overload in base"; }
    }
    public class DerivedClass2 : BaseClass2
    {
        public string Foo(object bar, int bar2 = 0)
        { return "object overload in derived"; }

        public string Foo(long bar)
        { return "Int64 overload in derived"; }
    }

    [TestClass]
    public class OverloadWithBase
    {
        [TestMethod]
        [TestCategory("Overloads")]
        public void OverloadsTest()
        {
            short x = 42;
            var y = 42;

            var derivedClass = new DerivedClass2();
            var baseClass = new BaseClass2();
            var derivedClassAsBase = derivedClass as BaseClass2;

            Assert.IsTrue(derivedClass.Foo(x).StartsWith("??"));
            Assert.IsTrue(baseClass.Foo(x).StartsWith("??"));
            Assert.IsTrue(derivedClassAsBase.Foo(42).StartsWith("??"));
        }

    }
}
