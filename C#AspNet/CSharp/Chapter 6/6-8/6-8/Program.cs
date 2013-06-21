using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows to print: ");
            string r = Console.ReadLine();
            double row = double.Parse(r);
            int k = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
                Console.ReadLine();
        }
    }
}
