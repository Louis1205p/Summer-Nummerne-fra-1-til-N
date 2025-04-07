using SummerNummerne;
using System;
using System.Diagnostics;
using System.Net;

namespace SummerNummerne
{
    class WhileLoopClass : IWhileLoop
    {
        public int SumBeregner(int input)
        {
            int i = 1;
            int sum = 0;

            while (i <= input)
            {
                sum += i;
                i++;
            }
            return sum;
        }
    }
}
