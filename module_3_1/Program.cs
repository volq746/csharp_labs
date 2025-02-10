﻿using System.Numerics;

namespace module_3_1
{

    internal class Program
    {
        static long ffactorial(int n)
        {
            long res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        static long rfactorial(int n)
        {
            return n < 1 ? 1 : n * rfactorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ffactorial(10));
            Console.WriteLine(rfactorial(10));
        }
    }
}
