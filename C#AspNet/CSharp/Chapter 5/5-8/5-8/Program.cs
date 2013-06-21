using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double P_Price, Yrs, depr;
            string p, y, d;
            Console.WriteLine("Enter the Purchase Price: ");
            p = Console.ReadLine();
            P_Price = double.Parse(p);
            Console.WriteLine("Enter the Years of Service: ");
            y = Console.ReadLine();
            Yrs = double.Parse(y);
            Console.WriteLine("Enter the annual depreciation: ");
            d = Console.ReadLine();
            depr = double.Parse(d);
            Console.WriteLine("The Salvage Value is " + (Yrs * depr) / P_Price);
            Console.ReadLine();
        }
    }
}
