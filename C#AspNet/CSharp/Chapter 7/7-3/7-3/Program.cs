using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum=0;
            Console.WriteLine("Enter the number: ");
            string x1 = Console.ReadLine();
            x = int.Parse(x1);
            while (x != 0)
            {
                int n = x % 10;
                sum = sum + n;
                x = x / 10;
            }
            Console.WriteLine("The sum of the digits of the given number is: " + sum);
            Console.ReadLine();
        }
    }
}
