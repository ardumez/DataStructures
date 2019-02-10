using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinarySearchTree
    {
        private Node _root;

        public void Insert(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                return;
            }

            if (value < _root.Value)
            {
                _root.Left = new Node(value);
                return;
            }

            if (value > _root.Value)
            {
                _root.Right = new Node(value);
                return;
            }
        }

        /// <summary>
        /// AVL Balance 
        /// </summary>
        public void InsertAndBalance(int value)
        {

        }

        private void Balance(Node node)
        {
            if (node.Left != null)
            {
                if (node.Left.Left != null)
                {

                }
            }
        }

        public void GetHeight()
        {
            int height = 0;

            Node current = _root;

            Stack<Node> currentLevel = new Stack<Node>();
            currentLevel.Push(_root);

            while(true)
            {
                var nextLevel = new Stack<Node>();

                while(currentLevel.Count != 0)
                {
                    var node = currentLevel.Pop();
                    if (node.Left != null)
                    {
                        nextLevel.Push(node.Left);
                    }
                    if (node.Right != null)
                    {
                        nextLevel.Push(node.Right);
                    }
                }

                if (nextLevel.Count == 0)
                    break;

                currentLevel = nextLevel;
            }
        }
    }

    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
