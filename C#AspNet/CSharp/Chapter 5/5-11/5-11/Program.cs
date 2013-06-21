using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string d, s, h;
            double tbo, eoq, dr, sc, hc;
            Console.WriteLine("Enter the demand rate(items per unit time: ): ");
            d = Console.ReadLine();
            Console.WriteLine("Enter the setup costs(per order): ");
            s = Console.ReadLine();
            Console.WriteLine("Enter the holding cost(per item per unit time: ): ");
            h = Console.ReadLine();
            dr = double.Parse(d);
            sc = double.Parse(s);
            hc = double.Parse(h);
            eoq = Math.Sqrt((2 * dr * sc) / hc);
            tbo = Math.Sqrt((2 * sc) / (dr * hc));
            Console.WriteLine("The Economic Order Quantity is: " + eoq);
            Console.WriteLine("The Time Between Orders is: " + tbo);
            Console.ReadLine();
        }
    }
}
