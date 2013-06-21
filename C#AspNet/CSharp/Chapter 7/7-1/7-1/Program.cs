using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0; string x1;
            Console.WriteLine("Enter a number: ");
            x1 = Console.ReadLine();
            x = int.Parse(x1);
            while (x > 0)
            {
                int n = x % 10;
                y = (10*y) + n;
                x = x / 10;
            }
            Console.WriteLine("The reverse of the given number is: " + y);
            Console.ReadLine();
        }
    }
}
