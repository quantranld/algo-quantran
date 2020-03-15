using System;
using System.Collections.Generic;
using System.Text;

namespace tree
{
    public class Node<T> where T : IComparable<T>
    {
        //public Node<T> Parent { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class NodeState<T> where T : IComparable<T>
    {
        public Node<T> Node { get; set; }
        public bool hasCheckedLeft { get; set; }
        public bool hasCheckedRight { get; set; }

        public NodeState(Node<T> node)
        {
            Node = node;
        }
    }

    public class BTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public void DFSPreOrder_withoutState()
        {
            var currentNode = this.Root;
            var stack = new Stack<Node<T>>();
            stack.Push(currentNode);
            var result = new List<T> { currentNode.Value };

            int numberOfNode = 4;
            for (int i = 0; i < numberOfNode; i++)
            {
                if (currentNode != null)
                {
                    if (currentNode.Left != null)
                    {
                        currentNode = currentNode.Left;
                        stack.Push(currentNode);
                        result.Add(currentNode.Value);
                    }
                    else if (currentNode.Right != null)
                    {
                        currentNode = currentNode.Right;
                        stack.Push(currentNode);
                        result.Add(currentNode.Value);
                    }
                    else
                    {
                        stack.Pop();
                        if (stack.Count > 0) currentNode = stack.Pop();
                        else currentNode = null;
                    }
                }
                else break;
            }

            _printOutList(result);
        }

        public void DFSPreOrder_withState()
        {
            var currentNode = new NodeState<T>(this.Root);
            var stack = new Stack<NodeState<T>>();
            stack.Push(currentNode);
            var result = new List<T> { currentNode.Node.Value };

            int numberOfNode = 10;
            for (int i = 0; i < numberOfNode; i++)
            {
                if (currentNode != null)
                {
                    if (currentNode.Node.Left != null && !currentNode.hasCheckedLeft)
                    {
                        currentNode.hasCheckedLeft = true;
                        currentNode = new NodeState<T>(currentNode.Node.Left);
                        
                        stack.Push(currentNode);
                        result.Add(currentNode.Node.Value);
                    }
                    else if (currentNode.Node.Right != null && !currentNode.hasCheckedRight)
                    {
                        currentNode.hasCheckedRight = true;
                        currentNode = new NodeState<T>(currentNode.Node.Right);
                        
                        stack.Push(currentNode);
                        result.Add(currentNode.Node.Value);
                    }
                    else
                    {
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            currentNode = stack.Peek();
                        }
                        else currentNode = null;
                    }
                }
                else break;
            }

            _printOutList(result);
        }

        public void DFSPreOrder_Recursive()
        {
            var result = new List<T>();
            _traverse(this.Root);
            _printOutList(result);

            void _traverse(Node<T> node)
            {
                if (node != null)
                {
                    result.Add(node.Value);
                    _traverse(node.Left);
                    _traverse(node.Right);
                }
            }
        }

        public void DFSInOrder_Recursive()
        {
            var result = new List<T>();
            _traverse(this.Root);
            _printOutList(result);

            void _traverse(Node<T> node)
            {
                if (node != null)
                {
                    _traverse(node.Left);
                    result.Add(node.Value);
                    _traverse(node.Right);
                }
            }
        }

        public void DFSPostOrder_Recursive()
        {
            var result = new List<T>();
            _traverse(this.Root);
            _printOutList(result);

            void _traverse(Node<T> node)
            {
                if (node != null)
                {
                    _traverse(node.Left);
                    _traverse(node.Right);
                    result.Add(node.Value);
                }
            }
        }

        public void BFS_Recursive()
        {
            var queue = new Queue<Node<T>>();
            var result = new List<T>();
            queue.Enqueue(this.Root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                result.Add(currentNode.Value);
                if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
            }

            _printOutList(result);
        }

        private void _printOutList(List<T> list)
        {
            list.ForEach(l =>
            {
                Console.WriteLine(l.ToString());
            });
            Console.ReadKey();
        }
    }
}
