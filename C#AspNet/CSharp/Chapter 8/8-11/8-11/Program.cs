using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_11
{
    class Program
    {
        static bool prime(ref int n)
        {
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    return false; break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be checked prime or not: ");
            int n = int.Parse(Console.ReadLine());
            bool a = prime(ref n);
            Console.WriteLine(a);
        }
    }
}
