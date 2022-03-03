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

            myBinaryTree.Display();

        }
    }
}
