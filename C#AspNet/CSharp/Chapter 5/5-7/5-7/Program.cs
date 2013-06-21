using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in farhenheit: ");
            double F;
            string f;
            f = Console.ReadLine();
            F = double.Parse(f);
            Console.WriteLine("The temperature in Celsius scale is: " + (F - 32) / 1.8);
            Console.ReadLine();
        }
    }
}
