using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            int[,] a = {{1,2,3,4,5},{0,1,2,0,4},{2,3,4,1,0},{0,2,4,5,1},{1,0,1,1,1}};
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    b[j] = a[j,i];
                }
                Array.Reverse(b);
                for (int j = 0; j < 5; j++)
                {
                    a[j,i] = b[j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
