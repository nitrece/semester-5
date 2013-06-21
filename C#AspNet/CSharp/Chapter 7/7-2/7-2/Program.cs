using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,fact=1;
            Console.WriteLine("Enter the number which factorial to be calculated: ");
            string x1 = Console.ReadLine();
            x = int.Parse(x1);
            while (x > 1)
            {
                fact = x * fact;
                x--;
            }
            Console.WriteLine("The factorial of the given number is: " + fact);
            Console.ReadLine();
        }
    }
}
