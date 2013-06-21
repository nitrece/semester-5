using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1, b1, c1, d1, m1, n1;
            double a, b, c, d, m, n;
            Console.WriteLine("Enter a: ");
            a1 = Console.ReadLine();
            Console.WriteLine("Enter b: ");
            b1 = Console.ReadLine();
            Console.WriteLine("Enter c: ");
            c1 = Console.ReadLine();
            Console.WriteLine("Enter d: ");
            d1 = Console.ReadLine();
            Console.WriteLine("Enter m: ");
            m1 = Console.ReadLine();
            Console.WriteLine("Enter n: ");
            n1 = Console.ReadLine();
            a = double.Parse(a1);
            b = double.Parse(b1);
            c = double.Parse(c1);
            d = double.Parse(d1);
            m = double.Parse(m1);
            n = double.Parse(n1);
            if ((a * d) - (b * c) == 0)
            {
                Console.WriteLine("The equations doesn't have a uniwue soluction!!!");
            }
            else
            {
                double x1, x2;
                x1 = ((m * d) + (b * n)) / ((a * d) - (b * c));
                x2 = ((n * a) + (m * c)) / ((a * d) - (b * c));
                Console.WriteLine("The values of x1 and x2 are: "+x1+" "+x2);
            }
            Console.ReadLine();
        }
    }
}
