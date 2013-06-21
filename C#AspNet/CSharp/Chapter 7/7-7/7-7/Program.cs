using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Enter value in rupees " + i + ": ");
                string n1 = Console.ReadLine();
                double n = double.Parse(n1);
                Console.WriteLine("The value in dollar is " + n * 50);
            }
        }
    }
}
