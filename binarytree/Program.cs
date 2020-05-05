using algo_quantran.models;
using System;

namespace algo_quantran.binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            var BSTree = new BST<int>();

            foreach (var value in new int[5] { 5, 6, 3, 7, 2 })
            {
                //demoBTree.InsertWithLoop(value);
                BSTree.InsertWithRecursion(value);
            }

            var search = BSTree.SearchRecursive(4);
            var search2 = BSTree.SearchRecursive(7);
        }
    }
}
