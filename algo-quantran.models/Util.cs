using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace algo_quantran.models
{
    public static class Util<T> where T : IComparable<T>
    {
        public static void PrintOutList(List<T> list)
        {
            list.ForEach(l =>
            {
                Console.WriteLine(l.ToString());
            });
            Console.ReadKey();
        }

        public static NodeCompareResult NodeCompare(Node<T> a, Node<T> b)
        {
            if (a.Value.Equals(b.Value)) return NodeCompareResult.Equal;
            if (a.Value.CompareTo(b.Value) > 0) return NodeCompareResult.GreaterThan;
            
            return NodeCompareResult.LessThan;
        }
    }
}
