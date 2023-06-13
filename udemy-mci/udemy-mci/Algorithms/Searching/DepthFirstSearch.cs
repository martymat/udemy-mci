using System;
using System.Collections.Generic;
using System.Text;
using udemy_mci.DataStructures;

namespace udemy_mci.Algorithms
{
    public class DepthFirstSearch
    {
        public static void DepthFirstSearchTester()
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

            InOrderSearch(binarySearchTree);
            PreOrderSearch(binarySearchTree);
            PostOrderSearch(binarySearchTree);
        }


        public static void InOrderSearch(BinarySearchTree binarySearchTree)
        {
            Console.Write("InOrder traversal: ");
            InOrderTraversal(binarySearchTree.root);
            Console.WriteLine();
        }

        private static void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Data + " ");
                InOrderTraversal(node.Right);
            }
        }

        public static void PreOrderSearch(BinarySearchTree binarySearchTree)
        {
            Console.Write("PreOrder traversal: ");
            PreOrderTraversal(binarySearchTree.root);
            Console.WriteLine();
        }

        private static void PreOrderTraversal(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public static void PostOrderSearch(BinarySearchTree binarySearchTree)
        {
            Console.Write("PostOrder traversal: ");
            PostOrderTraversal(binarySearchTree.root);
            Console.WriteLine();
        }

        private static void PostOrderTraversal(Node node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Data + " ");
            }
        }
    }
}
