using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var demoBTree = new BTree<string>();

            var nodeA = new Node<string>("A");
            var nodeB = new Node<string>("B");
            var nodeC = new Node<string>("C");
            var nodeD = new Node<string>("D");

            demoBTree.Root = nodeA;
            nodeA.Left = nodeB;
            nodeA.Right = nodeC;

            nodeB.Left = nodeD;

            //demoBTree.DFSPreOrder_withoutState();
            demoBTree.DFSPreOrder_withState();
        }
    }
}
