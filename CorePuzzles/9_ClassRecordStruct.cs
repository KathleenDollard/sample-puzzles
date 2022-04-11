//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Diagnostics;

//namespace CorePuzzles
//{
//    [TestClass]
//    public class ClassRecordStruct
//    {
//        public interface IPerson
//        {
//            string? Name { get; set; }
//        }

//        public class PersonClass : IPerson
//        {
//            public string? Name { get; set; }
//        }

//        private static T ChangeName<T>(T person)
//            where T : IPerson
//        {
//            person.Name = "Barney Rubble";
//            return person;
//        }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void ClassEquality()
//        {
//            var person1 = new PersonClass
//            { Name = "Fred Flintstone" };
//            var person2 = new PersonClass
//            { Name = "Fred Flintstone" };
//            //Assert.AreEqual(person1, person2);
//            Assert.AreNotEqual(person1, person2);
//        }

//        public struct PersonStruct : IPerson
//        { public string? Name { get; set; } }

//        public record PersonRecord() : IPerson
//        { public string? Name { get; set; } }

//        //public record struct PersonRecordStruct() : IPerson
//        //{ public string? Name { get; set; } = null; }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void StructEquality()
//        {
//            var person1 = new PersonStruct
//            { Name = "Fred Flintstone" };
//            var person2 = new PersonStruct
//            { Name = "Fred Flintstone" };
//            Assert.AreEqual(person1, person2);
//            //Assert.AreNotEqual(person1, person2);
//        }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void RecordEquality()
//        {
//            var person1 = new PersonRecord { Name = "Fred Flintstone" };
//            var person2 = new PersonRecord { Name = "Fred Flintstone" };

//            Assert.AreEqual(person1, person2);
//            //Assert.AreNotEqual(person1, person2);
//        }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void RecordStructEquality()
//        {
//            var person1 = new PersonRecordStruct { Name = "Fred Flintstone" };
//            var person2 = new PersonRecordStruct { Name = "Fred Flintstone" };
//            Assert.AreEqual(person1, person2);
//            //Assert.AreNotEqual(person1, person2);
//        }


//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void ClassAsParameter()
//        {
//            var person1 = new PersonClass
//            { Name = "Fred Flintstone" };
//            var person2 = ChangeName(person1);
//            Assert.AreEqual(person1.Name, person2.Name);
//            //Assert.AreNotEqual(person1.Name, person2.Name);
//        }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void StructAsParameter()
//        {
//            var person1 = new PersonStruct
//            { Name = "Fred Flintstone" };
//            var person2 = ChangeName(person1);

//            //Assert.AreEqual(person1.Name, person2.Name);
//            Assert.AreNotEqual(person1.Name, person2.Name);
//        }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void RecordAsParameter()
//        {
//            var person1 = new PersonRecord
//            { Name = "Fred Flintstone" };
//            var person2 = ChangeName(person1);

//            Assert.AreEqual(person1.Name, person2.Name);
//            //Assert.AreNotEqual(person1.Name, person2.Name);
//        }

//        [TestMethod]
//        //[ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
//        public void RecordStructAsParameter()
//        {
//            var person1 = new PersonRecordStruct
//            { Name = "Fred Flintstone" };
//            var person2 = ChangeName(person1);

//            Assert.AreEqual(person1.Name, person2.Name);
//            //Assert.AreNotEqual(person1.Name, person2.Name);
//        }
//    }
//}
