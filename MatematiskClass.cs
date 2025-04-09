using SummerNummerne;
using System;

namespace SummerNummerne
{
    class MatematiskClass : IWhileLoop
    {
        public int SumBeregner(int input)
        {
            return input * (input + 1) / 2;
        }
    }
}
