using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 5; j=j+2)
            {
                for (int i = 4; i >= j; i--)
                {
                    Console.Write(' ');
                }
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
            for (int j = 3; j >= 1; j = j - 2)
            {
                for (int i = 4; i >= j; i--)
                {
                    Console.Write(' ');
                }
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }

                Console.ReadKey(false);
        }
    }
}
