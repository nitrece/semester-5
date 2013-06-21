using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[9];
            for (int i = 0; i < 9; i++)
            {
                Console.Write("Enter the array values: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < (8-i); j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
