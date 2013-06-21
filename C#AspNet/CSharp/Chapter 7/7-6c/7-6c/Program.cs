using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_6c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n: ");
            string n1 = Console.ReadLine();
            n = int.Parse(n1);
            int m = n;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= m; k++)
                {
                    Console.Write(" ");
                }
                m--;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
