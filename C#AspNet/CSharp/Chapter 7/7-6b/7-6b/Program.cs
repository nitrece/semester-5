using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n: ");
            string n1 = Console.ReadLine();
            n = int.Parse(n1);
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n+1)-i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
