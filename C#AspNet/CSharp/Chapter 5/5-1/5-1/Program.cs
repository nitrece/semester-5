using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int x, y,sum,diff,product,div,mod;
            Console.WriteLine("Enter integer1: ");
            a = Console.ReadLine();
            Console.WriteLine("Enter integer2:");
            b = Console.ReadLine();
            x = int.Parse(a);
            y = int.Parse(b);
            sum = x + y;
            diff = x - y;
            product = x * y;
            div = x / y;
            mod = x % y;
            Console.WriteLine("The sum of the 2 integers is: " + sum);
            Console.WriteLine("The difference of the 2 integers is: " + diff);
            Console.WriteLine("The product of the 2 integers is: " + product);
            Console.WriteLine("The integer division of the 2 integers is: " + div);
            Console.WriteLine("The modulus division of the 2 integers is: " + mod);
            Console.ReadLine();
        }
    }
}
