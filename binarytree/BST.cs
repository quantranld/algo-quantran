using algo_quantran.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace algo_quantran.binarytree
{
    public class BST<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }
        private Func<Node<T>, Node<T>, NodeCompareResult> compareFn = Util<T>.NodeCompare;
        public void InsertWithLoop(T newValue)
        {
            var newNode = new Node<T>(newValue);
            var node = this.Root;
            if (node == null)
            {
                this.Root = newNode;
                node = newNode;
            }

            while (true)
            {
                var compareResult = compareFn(node, newNode);
                if (compareResult == NodeCompareResult.LessThan)
                {
                    if (node.Right != null) node = node.Right;
                    else
                    {
                        node.Right = newNode;
                        break;
                    }
                }
                else if (compareResult == NodeCompareResult.GreaterThan)
                {
                    if (node.Left != null) node = node.Left;
                    else
                    {
                        node.Left = newNode;
                        break;
                    }
                }
                else
                {
                    // equal
                    // can override
                    // or use a list of node to save all the duplicated nodes
                    break;
                }
            }
        }

        public void InsertWithRecursion(T newValue)
        {
            var newNode = new Node<T>(newValue);
            if (this.Root == null)
            {
                this.Root = newNode;
            }

            recursive(this.Root, newNode);

            void recursive(Node<T> parentNode, Node<T> insertNode)
            {
                var compareResult = compareFn(parentNode, insertNode);
                if (compareResult == NodeCompareResult.LessThan)
                {
                    if (parentNode.Right != null) recursive(parentNode.Right, insertNode);
                    else
                    {
                        parentNode.Right = insertNode;
                    }
                }
                else if (compareResult == NodeCompareResult.GreaterThan)
                {
                    if (parentNode.Left != null) recursive(parentNode.Left, insertNode);
                    else
                    {
                        parentNode.Left = insertNode;
                    }
                }
                else
                {
                    // equal
                    // can override
                    // or use a list of node to save all the duplicated nodes
                }
            }
        }
    }
}
