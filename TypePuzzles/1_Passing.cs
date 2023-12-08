using Newtonsoft.Json.Linq;
using System.Diagnostics.CodeAnalysis;

namespace IntrinsicTypeTests
{
    [SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
    [TestClass]
    public class Passing
    {
        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void PassVariables()
        {
            int value = 3;
            string greeting = "Hello";
            F(value, greeting);
            //Assert.AreEqual((3, "Hello"), (value, greeting));
            //Assert.AreEqual((4,"Hello"),(value,greeting));
            //Assert.AreEqual((3,"Goodbye"),(value,greeting));
            //Assert.AreEqual((4,"Goodbye"),(value,greeting));
        }



        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void PassClass()
        {
            GreetingClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            FClass(g);
            //Assert.AreEqual((3,"Hello"),  (g.Value,g.Greeting));
            //Assert.AreEqual((4,"Hello"),  (g.Value,g.Greeting));
            //Assert.AreEqual((3,"Goodbye"),(g.Value,g.Greeting));
            //Assert.AreEqual((4, "Goodbye"), (g.Value, g.Greeting));
        }



        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void PassStruct()
        {
            GreetingStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            FStruct(g);
            //Assert.AreEqual((3, "Hello"), (g.Value, g.Greeting));
            //Assert.AreEqual((4,"Hello"),  (g.Value,g.Greeting));
            //Assert.AreEqual((3,"Goodbye"),(g.Value,g.Greeting));
            //Assert.AreEqual((4, "Goodbye"), (g.Value, g.Greeting));
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void PassRecordRecordClass()
        {
            GreetingClass g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            FClass(g);
            //Assert.AreEqual((3,"Hello"),  (g.Value,g.Greeting));
            //Assert.AreEqual((4,"Hello"),  (g.Value,g.Greeting));
            //Assert.AreEqual((3,"Goodbye"),(g.Value,g.Greeting));
            //Assert.AreEqual((4, "Goodbye"), (g.Value, g.Greeting));
        }



        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void PassRecordStruct()
        {
            GreetingRecordStruct g = new()
            {
                Value = 3,
                Greeting = "Hello"
            };
            FRecordStruct(g);
            //Assert.AreEqual((3, "Hello"), (g.Value, g.Greeting));
            //Assert.AreEqual((4,"Hello"),  (g.Value,g.Greeting));
            //Assert.AreEqual((3,"Goodbye"),(g.Value,g.Greeting));
            //Assert.AreEqual((4, "Goodbye"), (g.Value, g.Greeting));
        }



        private void F(int value, string greeting)
        {
            value += 1;
            greeting = "Goodbye";
        }

        private void FClass(GreetingClass greeting)
        {
            greeting.Value += 1;
            greeting.Greeting = "Goodbye";
        }

        private void FStruct(GreetingStruct greeting)
        {
            greeting.Value += 1;
            greeting.Greeting = "Goodbye";
        }

        private void FRecordStruct(GreetingRecordStruct greeting)
        {
            greeting.Value += 1;
            greeting.Greeting = "Goodbye";
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
