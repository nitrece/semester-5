using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double u, a, t, s;
            string u1, a1, t1;
            Console.WriteLine("Enter u(m/s): ");
            u1 = Console.ReadLine();
            Console.WriteLine("Enter a(m/s^2): ");
            a1 = Console.ReadLine();
            Console.WriteLine("Enter t(s): ");
            t1 = Console.ReadLine();
            t = double.Parse(t1);
            u = double.Parse(u1);
            a = double.Parse(a1);
            s = (u * t) + ((1 / 2.0) * a * t * t);
            Console.WriteLine("The distance travelled is: " + s +"m");
            Console.ReadLine();
        }
    }
}
