using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, c = 0;
            for (int i = 100; i <= 200; i++)
            {
                if (i % 7 == 0)
                {
                    c++;
                    sum = sum + i;
                }
            }
            Console.WriteLine("The number of integers divisible by 7 are: " + c);
            Console.WriteLine("The sum of the integers divisible by 7 are: " + sum);
            Console.ReadLine();
        }
    }
}
