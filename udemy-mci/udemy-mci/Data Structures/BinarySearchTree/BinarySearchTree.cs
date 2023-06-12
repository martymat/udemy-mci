using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class BinarySearchTree
    {
        /*
               9
          4        20
        1   6   ()  170
        
        */

        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        /// <summary>
        ///  if root is null, then insert new node without children
        ///  else loop through and check if incoming data is greater than the currentNode.Data
        ///     if it is, then check if the currentNode.Right != null, if it is then make currentNode = currentNode.Right
        ///  same for less than/left
        /// </summary>
        /// <param name="data">incoming data to insert into tree</param>
        public void Insert(int data)
        {
            var nodeToInsert = new Node(data);

            if (root == null)
            {
                root = nodeToInsert;
            }
            else
            {
                var currentNode = root;

                while (currentNode != null)
                {
                    if (data > currentNode.Data)
                    {
                        if (currentNode.Right != null)
                        {
                            currentNode = currentNode.Right;
                        }
                        else
                        {
                            currentNode.Right = nodeToInsert;
                            break;
                        }
                    }
                    else if (data < currentNode.Data)
                    {
                        if (currentNode.Left != null)
                        {
                            currentNode = currentNode.Left;
                        }
                        else
                        {
                            currentNode.Left = nodeToInsert;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// if incoming data is greater than current node, look right
        /// same for left
        /// if reach null, then false
        /// </summary>
        /// <param name="data">incoming data to look for in tree</param>
        public void IsNodeExistent(int data)
        {
            if (root == null)
            {
                Console.WriteLine("root doesn't exist");
            }
            else
            {
                var currentNode = root;

                while (currentNode != null)
                {
                    if (data > currentNode.Data)
                    {
                        currentNode = currentNode.Right;
                    }
                    else if (data < currentNode.Data)
                    {
                        currentNode = currentNode.Left;
                    }

                    if (currentNode == null)
                    {
                        Console.WriteLine("Value does not exist");
                        break;
                    }
                    else if (data == currentNode.Data)
                    {
                        Console.WriteLine("Value does exist!");
                        break;
                    }
                }
            }
        }

        public void Traverse()
        {
            int treeHeight = GetTreeHeight(root);
            for (int level = 1; level <= treeHeight; level++)
            {
                PrintGivenLevel(root, level);
                Console.WriteLine();
            }
        }

        private int GetTreeHeight(Node root)
        {
            if (root == null)
                return 0;

            int leftHeight = GetTreeHeight(root.Left);
            int rightHeight = GetTreeHeight(root.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        private void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
            {
                PrintEmptySpaces(level);
                Console.Write(" ");
            }
            else if (level == 1)
            {
                Console.Write(root.Data);
                PrintEmptySpaces(level);
            }
            else if (level > 1)
            {
                PrintGivenLevel(root.Left, level - 1);
                PrintGivenLevel(root.Right, level - 1);
            }
        }

        private void PrintEmptySpaces(int count)
        {
            for (int i = 0; i < count; i++)
                Console.Write("  ");
        }
    }
}
