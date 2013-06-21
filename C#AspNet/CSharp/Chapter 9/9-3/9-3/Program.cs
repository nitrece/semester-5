using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[5];
            double[] y = new double[5];
            double m = 0, c = 0, p = 0, sx = 0, sy = 0, sq = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter x" + i + ": ");
                x[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter y" + i + ": ");
                y[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sx = sx + x[i];
                sy = sy + y[i];
                p = p + (x[i] * y[i]);
                sq = sq + (x[i] * x[i]);
            }
            m = ((5 * p) - (sx)*(sy)) / (5 * sq - (sx * sx));
            c = (sy - (m * sx)) / 5;
            Console.WriteLine("The equation of the line is y = " + m + "x + " + c);
        }
    }
}
