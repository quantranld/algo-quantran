using algo_quantran.models;
using System;

namespace algo_quantran.binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoBTree = new BST<int>();

            foreach (var value in new int[5] { 5, 6, 3, 7, 2 })
            {
                //demoBTree.InsertWithLoop(value);
                demoBTree.InsertWithRecursion(value);
            }
        }
    }
}
