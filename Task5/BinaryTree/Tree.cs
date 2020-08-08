using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// BinaryTree class and methods for working with them.
    /// </summary>
    /// <typeparam name="T">Universal parameter.</typeparam>
    [Serializable]
    public class Tree<T> where T : IComparable<T>
    {
        /// <summary>
        /// Parent of binary tree.
        /// </summary>
        public Tree<T> Parent { get; set; }

        /// <summary>
        /// Left nodes of binary tree.
        /// </summary>
        public Tree<T> Left { get; set; }

        /// <summary>
        /// Right nodes of binary tree.
        /// </summary>
        public Tree<T> Right { get; set; }

        /// <summary>
        /// Value of universal parameter.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Constrictor of this class.
        /// </summary>
        /// <param name="value">Value of universal parameter.</param>
        /// <param name="parent">Parent of binary tree.</param>
        public Tree(T value, Tree<T> parent)
        {
            Value = value;
            Parent = parent;
        }

        /// <summary>
        /// Constrictor of this class.
        /// </summary>
        public Tree() { }

        /// <summary>
        /// Method to add value to binary tree.
        /// </summary>
        /// <param name="value">Value of universal parameter.</param>
        public void Add(T value)
        {
            if (value.CompareTo(Value) < 0)
            {
                if (Left == null)
                    Left = new Tree<T>(value, this);
                else if (Left != null)
                    Left.Add(value);
            }
            else
            {
                if (Right == null)
                    Right = new Tree<T>(value, this);
                else if (Right != null)
                    Right.Add(value);
            }
        }
    }
}
