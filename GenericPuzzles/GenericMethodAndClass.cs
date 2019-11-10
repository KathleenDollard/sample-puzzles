using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPuzzles
{
   public class Dummy
   {
      public void Bar()
      {
            //GenericClass<string>.F("Hello World");
            //GenericClass<string>.F2(42);
            //NonGenericClass.F("Hello World");
            //NonGenericClass.F2(42);
        }
   }

   public class GenericClass<T>
   {
      public static void F(T param) { }
      public static void F2(T param) { }
   }

   public class NonGenericClass
   {
      public static void F<T>(T param) { }
      public static void F2<T>(T param) { }
   }
}
