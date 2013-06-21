using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter x: ");
            string x1 = Console.ReadLine();
            x = double.Parse(x1);
            if (x > 0)
                y = 1;
            else
                if (x < 0)
                    y = -1;
                else
                    y = 0;
            Console.WriteLine("y= "+y);
            Console.ReadLine();
        }
    }
}
