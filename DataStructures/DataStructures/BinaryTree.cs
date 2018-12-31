using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinaryTree
    {
        private Node _root;

        public void Insert(int parent, int value)
        {

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
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
