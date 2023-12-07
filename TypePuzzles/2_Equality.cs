using Newtonsoft.Json.Linq;
using System.Diagnostics.CodeAnalysis;

namespace IntrinsicTypeTests
{
    [SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
    [TestClass]
    public class Comparing
    {
        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareVariables()
        {
            int value = 3;
            string greeting = "Hello";
            int value2 = 3;
            string greeting2 = "Hello";

            //Assert.IsTrue((value, greeting) == (value2, greeting2));
            //Assert.IsFalse((value, greeting) == (value2, greeting2));
        }



        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareClass()
        {
            GreetingClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            GreetingClass g2 = new()
            {
                Value = 3,
                Greeting = "Hello"
            };

            //Assert.IsTrue(g == g2);
            //Assert.IsFalse(g == g2);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareClass2()
        {
            GreetingClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;

            //Assert.IsTrue(g == g3);
            //Assert.IsFalse(g == g3);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareStruct()
        {
            GreetingStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            GreetingStruct g2 = new()
            {
                Value = 3,
                Greeting = "Hello"
            };

            // struct does not have a equality operator by default
            //Assert.IsTrue(g.Equals(g2));
            //Assert.IsFalse(g.Equals(g2));
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareStruct2()
        {
            GreetingStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;

            // struct does not have a equality operator by default
            //Assert.IsTrue(g.Equals(g3));
            //Assert.IsFalse(g.Equals(g3));
        }






        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ChangeClass()
        {
            GreetingClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;
            g.Value += 1;
            g.Greeting = "Goodbye";

            //Assert.IsTrue(g == g3);
            //Assert.IsFalse(g == g3);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ChangeStruct()
        {
            GreetingStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;
            g.Value += 1;
            g.Greeting = "Goodbye";

            //Assert.IsTrue(g.Equals(g3));
            //Assert.IsFalse(g.Equals(g3));
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareRecordClass()
        {
            GreetingRecordClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            GreetingRecordClass g2 = new()
            {
                Value = 3,
                Greeting = "Hello"
            };

            //Assert.IsTrue(g == g2);
            //Assert.IsFalse(g == g2);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareRecordClass2()
        {
            GreetingRecordClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;

            //Assert.IsTrue(g == g3);
            //Assert.IsFalse(g == g3);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareRecordStruct()
        {
            GreetingRecordStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            GreetingRecordStruct g2 = new()
            {
                Value = 3,
                Greeting = "Hello"
            };

            // struct does not have a equality operator by default
            //Assert.IsTrue(g.Equals(g2));
            //Assert.IsFalse(g.Equals(g2));
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void CompareRecordRecordStruct2()
        {
            GreetingRecordStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;

            // struct does not have a equality operator by default
            //Assert.IsTrue(g.Equals(g3));
            //Assert.IsFalse(g.Equals(g3));
        }






        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ChangeRecordClass()
        {
            GreetingRecordClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;
            g.Value += 1;
            g.Greeting = "Goodbye";

            //Assert.IsTrue(g == g3);
            //Assert.IsFalse(g == g3);
        }


        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void ChangeRecordStruct()
        {
            GreetingRecordStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            var g3 = g;
            g.Value += 1;
            g.Greeting = "Goodbye";

            //Assert.IsTrue(g.Equals(g3));
            //Assert.IsFalse(g.Equals(g3));
        }


        private class GreetingClass
        {
            public int Value { get; set; }
            public string? Greeting { get; set; }
        }

        private struct GreetingStruct
        {
            public int Value { get; set; }
            public string? Greeting { get; set; }
        }


        private record class GreetingRecordClass
        {
            public int Value { get; set; }
            public string? Greeting { get; set; }
        }

        private record struct GreetingRecordStruct
        {
            public int Value { get; set; }
            public string? Greeting { get; set; }
        }
    }
}
