using System;
using System.Collections.Generic;
using System.Text;

namespace algo_quantran.models
{
    public static class Util<T>
    {
        public static void PrintOutList(List<T> list)
        {
            list.ForEach(l =>
            {
                Console.WriteLine(l.ToString());
            });
            Console.ReadKey();
        }
    }
}
