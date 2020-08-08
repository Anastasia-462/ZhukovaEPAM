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

        /// <summary>
        /// Method to search values in binary tree.
        /// </summary>
        /// <param name="value">Value of universal parameter.</param>
        /// <returns>The found node.</returns>
        public Tree<T> Searching(T value)
        {
            return Search(this, value);
        }

        /// <summary>
        /// Method to remove nodes from binary tree.
        /// </summary>
        /// <param name="value">Value of universal parameter.</param>
        /// <returns>True it the node was deleted and false in th opposite case.</returns>
        public bool Remove(T value)
        {
            Tree<T> tree = Searching(value);
            if (tree == null)
                return false;

            Tree<T> curTree;

            //When deleting the root.
            if (tree == this)
            {
                if (tree.Right != null)
                    curTree = tree.Right;
                else
                    curTree = tree.Left;

                while (curTree.Left != null)
                {
                    curTree = curTree.Left;
                }
                T temp = curTree.Value;
                this.Remove(temp);
                tree.Value = temp;

                return true;
            }

            //Removing leaves.
            if ((tree.Left == null) && (tree.Right == null) && (tree.Parent != null))
            {
                if (tree == tree.Parent.Left)
                    tree.Parent.Left = null;
                else
                {
                    tree.Parent.Right = null;
                }
                return true;
            }

            //Removing a node that has a left subtree but no right subtree.
            if (tree.Left != null && tree.Right == null)
            {
                tree.Left.Parent = tree.Parent;
                if (tree == tree.Parent.Left)
                    tree.Parent.Left = tree.Left;
                else if (tree == tree.Parent.Right)
                    tree.Parent.Right = tree.Left;
                return true;
            }

            //Removing a node that has a right subtree but no left subtree.
            if ((tree.Left == null) && (tree.Right != null))
            {
                tree.Right.Parent = tree.Parent;
                if (tree == tree.Parent.Left)
                    tree.Parent.Left = tree.Right;
                else if (tree == tree.Parent.Right)
                    tree.Parent.Right = tree.Right;
                return true;
            }

            //Delete a node that has subtrees on both sides.
            if ((tree.Right != null) && (tree.Left != null))
            {
                curTree = tree.Right;

                while (curTree.Left != null)
                {
                    curTree = curTree.Left;
                }

                //If the leftmost element is the first child.
                if (curTree.Parent == tree)
                {
                    curTree.Left = tree.Left;
                    tree.Left.Parent = curTree;
                    curTree.Parent = tree.Parent;
                    if (tree == tree.Parent.Left)
                    {
                        tree.Parent.Left = curTree;
                    }
                    else if (tree == tree.Parent.Right)
                    {
                        tree.Parent.Right = curTree;
                    }
                    return true;
                }
                //If the leftmost element is NOT the first child.
                else
                {
                    if (curTree.Right != null)
                    {
                        curTree.Right.Parent = curTree.Parent;
                    }
                    curTree.Parent.Left = curTree.Right;
                    curTree.Right = tree.Right;
                    curTree.Left = tree.Left;
                    tree.Left.Parent = curTree;
                    tree.Right.Parent = curTree;
                    curTree.Parent = tree.Parent;
                    if (tree == tree.Parent.Left)
                    {
                        tree.Parent.Left = curTree;
                    }
                    else if (tree == tree.Parent.Right)
                    {
                        tree.Parent.Right = curTree;
                    }

                    return true;
                }
            }
            return false;
        }

        //Method for searching node.
        private Tree<T> Search(Tree<T> tree, T value)
        {
            if (tree == null)
                return null;
            switch (value.CompareTo(tree.Value))
            {
                case 1:
                    return Search(tree.Right, value);
                case -1:
                    return Search(tree.Left, value);
                case 0:
                    return tree;
                default:
                    return null;
            }
        }
    }
}
