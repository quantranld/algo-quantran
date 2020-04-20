using System;
using algo_quantran.models;

namespace algo_quantran.tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoBTree = new BFSDFSTree<string>();
            demoBTree.Root = new Node<string>("A");
            demoBTree.Root.Left = new Node<string>("B");
            demoBTree.Root.Right = new Node<string>("C");
            demoBTree.Root.Right.Left = new Node<string>("E");
            demoBTree.Root.Right.Right = new Node<string>("F");

            demoBTree.Root.Left.Left = new Node<string>("D");

            //demoBTree.DFSPreOrder_withoutState();
            //demoBTree.DFSPreOrder_withState();
            //demoBTree.DFSPreOrder_Recursive();
            //demoBTree.DFSInOrder_Recursive();
            //demoBTree.DFSPostOrder_Recursive();
            demoBTree.BFS_Recursive();
        }
    }
}
