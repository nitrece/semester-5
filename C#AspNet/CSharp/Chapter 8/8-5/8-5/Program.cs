using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_5
{
    class Program
    {
        static void PrintLine(ref char a1, ref int b1)
        {
            for (int i = 1; i <= b1; i++)
            {
                Console.Write(a1);
            }
            Console.WriteLine();
            for (int i = 1; i <= b1+9; i++)
            {
                Console.Write((char)(a1+5));
            }
            Console.WriteLine();
            for (int i = 1; i <= b1+18; i++)
            {
                Console.Write((char)(a1 + 10));
            }
        }
        static void Main(string[] args)
        {
            char a; int b;
            Console.WriteLine("Enter a character: ");
            a=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter length: ");
            b = int.Parse(Console.ReadLine());
            PrintLine(ref a,ref b);
        }
    }
}
