using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0; float root = 0;
            Console.Write("NUMBER\t\t");
            for (double k = 0; k <= 9; k++)
            {
                Console.Write(k / 10 + "\t\t");
            }
            Console.WriteLine();
                for (double i = 0; i <= 9; i++)
                {
                    Console.Write(i + "\t\t");
                    for (double j = 0; j <= 9; j++)
                    {
                        n = i + j / 10;
                        root = float.Parse(Math.Sqrt(n).ToString());
                        Console.Write(root + "\t\t");
                    }
                    Console.WriteLine();
                }
            Console.ReadKey(false);
        }
    }
}
