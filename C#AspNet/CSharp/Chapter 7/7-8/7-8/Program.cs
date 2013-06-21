using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine("Enter value in rupees " + x + ": ");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("The value in dollar is " + n /50);
            } while (x++ < 5);
        }
    }
}
