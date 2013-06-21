using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_2
{
    class Program
    {
        static void PrintLine()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("   C# Programming   ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {

            PrintLine();
        }
    }
}
