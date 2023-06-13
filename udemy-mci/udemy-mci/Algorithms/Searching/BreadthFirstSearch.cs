using System;
using System.Collections.Generic;
using System.Text;
using udemy_mci.DataStructures;

namespace udemy_mci.Algorithms
{
    public class BreadthFirstSearch
    {
        public static void BreadthFirstSearchTester()
        {
            /*
                   9
              4        20
            1   6   15  170

            */

            var binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(120);

            Search(binarySearchTree);
        }

        public static void Search(BinarySearchTree binarySearchTree)
        {
            var root = binarySearchTree.root;
            if (root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();
                Console.Write(currentNode.Data + " ");

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
        }
    }
}
