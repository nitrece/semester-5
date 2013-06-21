using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, se = 0,so=0;
        ajit:
            if (i <= 20)
            {
                if (i % 2 == 1)
                    so = so + i;
                else
                    se = se + i;
                i++;
                goto ajit;
            }
            Console.WriteLine("odd sum= " + so);
            Console.WriteLine("even sum= " + se); 
            Console.ReadLine();
        }
    }
}
