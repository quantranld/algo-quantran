using System;

namespace algo_quantran.models
{
    public class Node<T> where T : IComparable<T>
    {
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

    public enum NodeCompareResult
    {
        Equal = 0,
        GreaterThan = 1,
        LessThan = 2
    }
}
