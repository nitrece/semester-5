using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            double x, y, sum, diff, product, div, mod;
            Console.WriteLine("Enter 1st double type value: ");
            a = Console.ReadLine();
            Console.WriteLine("Enter 2nd double type value:");
            b = Console.ReadLine();
            x = double.Parse(a);
            y = double.Parse(b);
            sum = x + y;
            diff = x - y;
            product = x * y;
            div = x / y;
            mod = x % y;
            Console.WriteLine("The sum of the 2 values is: " + sum);
            Console.WriteLine("The difference of the 2 values is: " + diff);
            Console.WriteLine("The product of the 2 values is: " + product);
            Console.WriteLine("The division of the 2 values is: " + div);
            Console.WriteLine("The modulus division of the 2 values is: " + mod);
            Console.ReadLine();
        }
    }
}
