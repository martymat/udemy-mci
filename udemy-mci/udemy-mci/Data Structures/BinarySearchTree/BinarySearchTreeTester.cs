using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class BinarySearchTreeTester
    {
        public static void TestBinarySearchTree()
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
            binarySearchTree.Traverse();
            binarySearchTree.IsNodeExistent(6);
        }
    }
}
