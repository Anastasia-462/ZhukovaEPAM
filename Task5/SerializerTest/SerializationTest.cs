using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializer;

namespace SerializerTest
{
    /// <summary>
    /// Class for testing Serilization.
    /// </summary>
    [TestClass]
    public class SerializationTest
    {
        /// <summary>
        /// Test for cheching class xml serialization.
        /// </summary>
        [TestMethod]
        public void TestClass_XmlSerialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Assert.IsTrue(Serialization<Student>.XmlSerialization("Student.xml", student));
        }

        /// <summary>
        /// Test for cheching colection xml serialization.
        /// </summary>
        [TestMethod]
        public void TestCollection_XmlSerialization()
        {
            StudentCollection students = new StudentCollection();
            students.Add(new Student("Artem", "History", new DateTime(2012, 10, 5), 7));
            students.Add(new Student("Misha", "Math", new DateTime(2012, 10, 9), 5));
            students.Add(new Student("Alena", "OOP", new DateTime(2012, 10, 14), 8));
            students.Add(new Student("Lena", "History", new DateTime(2012, 10, 5), 9));
            Assert.IsTrue(Serialization<StudentCollection>.XmlSerialization("Student.xml", students));
        }

        /// <summary>
        /// Test for cheching class xml deserialization.
        /// </summary>
        [TestMethod]
        public void TestClass_XmlDeserialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Serialization<Student>.XmlSerialization("Student.xml", student);
            Student studentNew = Serialization<Student>.XmlDeserialization("Student.xml", student.GetHashCode());
            Assert.AreEqual(student, studentNew);
        }

        /// <summary>
        /// Test for cheching version of class xml deserialization.
        /// </summary>
        [TestMethod]
        public void TestVersion_XmlDeserialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Serialization<Student>.XmlSerialization("Student.xml", student);
            Student studentNew = Serialization<Student>.XmlDeserialization("Student.xml", 155);
            Assert.AreEqual(default(Student), studentNew);
        }

        /// <summary>
        /// Test for cheching collection xml deserialization.
        /// </summary>
        [TestMethod]
        public void TestCollection_XmlDeserialization()
        {
            string actual = "";
            StudentCollection students = new StudentCollection();
            students.Add(new Student("Artem", "History", new DateTime(2012, 10, 5), 7));
            students.Add(new Student("Misha", "Math", new DateTime(2012, 10, 9), 5));
            students.Add(new Student("Alena", "OOP", new DateTime(2012, 10, 14), 8));
            students.Add(new Student("Lena", "History", new DateTime(2012, 10, 5), 9));
            Serialization<Student>.XmlSerialization("Student.xml", students);
            ICollection<Student> st = Serialization<Student>.XmlDeserializationCollection("Student.xml");
            foreach (Student student in st)
                actual += student.ToString();

            Assert.AreEqual(students.ToString(), actual);
        }


        /// <summary>
        /// Test for cheching class json serialization.
        /// </summary>
        [TestMethod]
        public void TestClass_JsonSerialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Assert.IsTrue(Serialization<Student>.JsonSerialization("Student.txt", student));
        }

        /// <summary>
        /// Test for cheching colection json serialization.
        /// </summary>
        [TestMethod]
        public void TestCollection_JsonSerialization()
        {
            StudentCollection students = new StudentCollection();
            students.Add(new Student("Artem", "History", new DateTime(2012, 10, 5), 7));
            students.Add(new Student("Misha", "Math", new DateTime(2012, 10, 9), 5));
            students.Add(new Student("Alena", "OOP", new DateTime(2012, 10, 14), 8));
            students.Add(new Student("Lena", "History", new DateTime(2012, 10, 5), 9));
            Assert.IsTrue(Serialization<StudentCollection>.JsonSerialization("Student.txt", students));
        }

        /// <summary>
        /// Test for cheching class xml deserialization.
        /// </summary>
        [TestMethod]
        public void TestClass_JsonDeserialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Serialization<Student>.JsonSerialization("JsonStudent.txt", student);
            Student studentNew = Serialization<Student>.JsonDeserialization("Student.txt", student.GetHashCode());
            Assert.AreEqual(student, studentNew);
        }

        /// <summary>
        /// Test for cheching version of class json deserialization.
        /// </summary>
        [TestMethod]
        public void TestVersion_JsonDeserialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Serialization<Student>.JsonSerialization("Student.txt", student);
            Student studentNew = Serialization<Student>.JsonDeserialization("Student.txt", 112);
            Assert.AreEqual(default(Student), studentNew);
        }

        /// <summary>
        /// Test for cheching collection xml serialization.
        /// </summary>
        [TestMethod]
        public void TestCollection_JsonDeserialization()
        {
            StudentCollection students = new StudentCollection();
            students.Add(new Student("Artem", "History", new DateTime(2012, 10, 5), 7));
            students.Add(new Student("Misha", "Math", new DateTime(2012, 10, 9), 5));
            students.Add(new Student("Alena", "OOP", new DateTime(2012, 10, 14), 8));
            students.Add(new Student("Lena", "History", new DateTime(2012, 10, 5), 9));
            Serialization<Student>.JsonSerialization("JsonStudent.txt", students);

            Assert.AreEqual(students, Serialization<Student>.JsonDeserializationCollection("Student.txt"));
        }


        /// <summary>
        /// Test for cheching class binary serialization.
        /// </summary>
        [TestMethod]
        public void TestClass_BinarySerialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Assert.IsTrue(Serialization<Student>.BinarySerialization("Student.bin", student));
        }

        /// <summary>
        /// Test for cheching colection binary serialization.
        /// </summary>
        [TestMethod]
        public void TestCollection_BinarySerialization()
        {
            StudentCollection students = new StudentCollection();
            students.Add(new Student("Artem", "History", new DateTime(2012, 10, 5), 7));
            students.Add(new Student("Misha", "Math", new DateTime(2012, 10, 9), 5));
            students.Add(new Student("Alena", "OOP", new DateTime(2012, 10, 14), 8));
            students.Add(new Student("Lena", "History", new DateTime(2012, 10, 5), 9));

            Assert.IsTrue(Serialization<StudentCollection>.BinarySerialization("Student.bin", students));
        }

        /// <summary>
        /// Test for cheching class binary deserialization.
        /// </summary>
        [TestMethod]
        public void TestClass_BinaryDeserialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);
            Serialization<Student>.BinarySerialization("Student.bin", student);
            Student studentNew = Serialization<Student>.BinaryDeserialization("Student.bin", student.GetHashCode());
            Assert.AreEqual(student, studentNew);
        }

        /// <summary>
        /// Test for cheching version of class binary deserialization.
        /// </summary>
        [TestMethod]
        public void TestVersion_BinaryDeserialization()
        {
            Student student = new Student("Artem", "History", new DateTime(2012, 10, 5), 9);

            Serialization<Student>.BinarySerialization("Student.bin", student);
            Student studentNew = Serialization<Student>.BinaryDeserialization("Student.bin", 112);

            Assert.AreEqual(default(Student), studentNew);
        }

        /// <summary>
        /// Test for cheching collection binary deserialization.
        /// </summary>
        [TestMethod]
        public void TestCollection_BinaryDeserialization()
        {
            string actual = "";
            StudentCollection students = new StudentCollection();
            students.Add(new Student("Artem", "History", new DateTime(2012, 10, 5), 7));
            students.Add(new Student("Misha", "Math", new DateTime(2012, 10, 9), 5));
            students.Add(new Student("Alena", "OOP", new DateTime(2012, 10, 14), 8));
            students.Add(new Student("Lena", "History", new DateTime(2012, 10, 5), 9));

            Serialization<Student>.BinarySerialization("Student.bin", students);
            ICollection<Student> st = Serialization<Student>.BinaryDeserializationCollection("Student.bin");

            foreach (Student student in st)
                actual += student.ToString();

            Assert.AreEqual(students.ToString(), actual);
        }
    }
}
