using System;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTest
{
    /// <summary>
    /// Class for testing BinaryTree.
    /// </summary>
    [TestClass]
    public class TreeTest
    {
        /// <summary>
        /// Test for checking Add method when adding a class.
        /// </summary>
        [TestMethod]
        public void TestAdd_StudentNode()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 10);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 12), 7));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));
            binaryTree.Add(new Student("Pasha", "math", new DateTime(2019, 3, 12), 2));
            Assert.AreEqual("10 (9 (8 (5 (1 (, 2 (, )), 7 (, )), 8 (, )), ), )", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Add method when adding a string.
        /// </summary>
        [TestMethod]
        public void TestAdd_StringNode()
        {
            Tree<string> binaryTree = new Tree<string>("Peace", null);
            binaryTree.Add("Magic");
            binaryTree.Add("Sins");
            binaryTree.Add("Madness");
            Assert.AreEqual("Peace (Magic (Madness (, ), ), Sins (, ))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Add method when adding an integer numbers.
        /// </summary>
        [TestMethod]
        public void TestAdd_IntNode()
        {
            Tree<int> binaryTree = new Tree<int>(80, null);
            binaryTree.Add(25);
            binaryTree.Add(1);
            binaryTree.Add(90);
            Assert.AreEqual("80 (25 (1 (, ), ), 90 (, ))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Remove method when removing a sheet.
        /// </summary>
        [TestMethod]
        public void TestDelete_Leaves()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 12), 7));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));
            binaryTree.Add(new Student("Pasha", "math", new DateTime(2019, 3, 12), 2));

            binaryTree.Remove(new Student("Pasha", "math", new DateTime(2019, 3, 12), 2));

            Assert.AreEqual("7 (5 (1 (, ), ), 8 (7 (, ), 9 (8 (, ), )))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Remove method when removing a root.
        /// </summary>
        [TestMethod]
        public void TestDelete_Root()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));
            binaryTree.Remove(new Student("Artem", "math", new DateTime(2019, 3, 12), 7));

            Assert.AreEqual("8 (5 (, ), 9 (, ))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Remove method when removing a node that has a left subtree but no right subtree.
        /// </summary>
        [TestMethod]
        public void TestDelete_NodeWithoutRight()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));

            binaryTree.Remove(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));

            Assert.AreEqual("7 (1 (, ), 8 (, 9 (8 (, ), )))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Remove method when removing a node that has a right subtree but no left subtree.
        /// </summary>
        [TestMethod]
        public void TestDelete_NodeWithoutLeft()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));

            binaryTree.Remove(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));

            Assert.AreEqual("7 (5 (1 (, ), ), 8 (, 8 (, )))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Remove method when removing a node that has subtrees on both sides.
        /// </summary>
        [TestMethod]
        public void TestDelete_NodeWithLeftAndRight()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 5, 11), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 12), 6));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 7, 12), 6));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));

            binaryTree.Remove(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));

            Assert.AreEqual("7 (6 (1 (, ), 6 (, )), 8 (, 9 (8 (, ), )))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking Remove method when removing a node that has subtrees on both sides and the right subtree has children
        /// </summary>
        [TestMethod]
        public void TestDelete_NodeWithLeftAndRightNode()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 5, 10), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 18), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 7, 12), 6));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));

            binaryTree.Remove(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));

            Assert.AreEqual("7 (5 (1 (, ), 6 (, )), 8 (, 9 (8 (, ), )))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for checking the correct balance of the tree.
        /// </summary>
        [TestMethod]
        public void TestBalanceTree()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 10);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 3, 12), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 12), 7));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));
            binaryTree.Add(new Student("Pasha", "math", new DateTime(2019, 3, 12), 2));
            binaryTree.Balance();
            Assert.AreEqual("8 (5 (2 (1 (, ), ), 7 (, )), 9 (8 (, ), 10 (, )))", binaryTree.ToString());
        }

        /// <summary>
        /// Test for verification of node search.
        /// </summary>
        [TestMethod]
        public void TestSearchingNode()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 18), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 7, 12), 6));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));
            Assert.AreEqual("9 (8 (, ), )", binaryTree.Searching(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9)).ToString());
        }

        /// <summary>
        /// Test for verifies correct serialization.
        /// </summary>
        [TestMethod]
        public void TestSerialization()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 5, 10), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 18), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 7, 12), 6));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));

            Assert.IsTrue(binaryTree.Serialization("student.xml"));
        }

        /// <summary>
        /// TTest for verifies correct deserialization.
        /// </summary>
        [TestMethod]
        public void TestDeserialization()
        {
            Student student = new Student("Artem", "math", new DateTime(2019, 3, 12), 7);
            Tree<Student> binaryTree = new Tree<Student>(student, null);
            binaryTree.Add(new Student("Oleg", "OOP", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Andrey", "math", new DateTime(2019, 3, 12), 9));
            binaryTree.Add(new Student("Katya", "BD", new DateTime(2019, 5, 10), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 3, 18), 5));
            binaryTree.Add(new Student("Misha", "math", new DateTime(2019, 7, 12), 6));
            binaryTree.Add(new Student("Olya", "BD", new DateTime(2019, 3, 12), 8));
            binaryTree.Add(new Student("Denis", "OOP", new DateTime(2019, 3, 12), 1));
            binaryTree.Serialization("student.xml");
            Assert.IsTrue(binaryTree.Deserialization("student.xml"));
        }
    }
}
