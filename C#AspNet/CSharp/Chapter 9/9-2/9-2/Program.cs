using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 0, 1, 0, 1 }, { 0, 1, 0, 1, 0 }, { 1, 0, 1, 0, 1 }, { 0, 1, 0, 1, 0 }, { 1, 0, 1, 0, 1 } };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
