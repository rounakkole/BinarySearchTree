// See https://aka.ms/new-console-template for more information
using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary search tree");

            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>();
            myBinaryTree.Insert(56);
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            myBinaryTree.Insert(22);
            myBinaryTree.Insert(40);
            myBinaryTree.Insert(60);
            myBinaryTree.Insert(95);
            myBinaryTree.Insert(65);
            myBinaryTree.Insert(63);
            myBinaryTree.Insert(67);
            myBinaryTree.Insert(11);
            myBinaryTree.Insert(3);
            myBinaryTree.Insert(16);

            myBinaryTree.Display();
            myBinaryTree.Size();
        }
    }
}
