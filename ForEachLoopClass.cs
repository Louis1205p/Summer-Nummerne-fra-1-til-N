using SummerNummerne;
using System;
using System.Linq;

namespace SummerNummerne
{
    public class ForEachLoopClass : IWhileLoop
    {
        public int SumBeregner(int input)
        {
            int sum = 0;

            foreach (var i in Enumerable.Range(1, input))
            {
                sum += i;
            }

            return sum;
        }
    }
}