using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_9
{
    class Program
    {
        static void flt(ref float n, ref int r)
        {
            float f=(float)System.Math.Round(n, r);
            Console.WriteLine(f);
        }
        static void Main(string[] args)
        {
            int r; float n;
            Console.WriteLine("Enter the number: ");
            n = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the decimal places: ");
            r=int.Parse(Console.ReadLine());
            flt(ref n,ref r);
        }
    }
}
