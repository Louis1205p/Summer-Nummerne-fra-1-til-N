using SummerNummerne;
using System;

namespace SummerNummerne
{
    class ForLoopClass : IWhileLoop
    {
        public int SumBeregner(int input)
        {
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
