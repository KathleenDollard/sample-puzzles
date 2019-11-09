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
         //Assert.AreEqual("Base Foo", b1.Foo(42));
         //Assert.AreEqual("Derived Foo", b1.Foo(42));
         //Assert.AreEqual("Base Foo", b1.Foo(George: 42));
         //Assert.AreEqual("Derived Foo", b1.Foo(George: 42));
         //Assert.AreEqual("Base Foo", b1.Foo(Fred: 42));
         //Assert.AreEqual("Derived Foo", b1.Foo(Fred: 42));
      }

      public class A1
      {
         public virtual string Foo(int Fred)
         { return "Base Foo"; }
      }

      public class B1 : A1
      {
         public override string Foo(int George)
         { return "Derived Foo"; }
      }
   }
}
