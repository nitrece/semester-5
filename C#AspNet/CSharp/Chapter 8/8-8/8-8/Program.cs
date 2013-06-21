using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_8
{
    class Program
    {
        static void space(ref int n)
        {
            int x = 2, y = 3;
            Console.Write(x);
            for (int i = 1; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.Write(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of spaces to be added: ");
            int n = int.Parse(Console.ReadLine());
            space(ref n);
        }
    }
}
