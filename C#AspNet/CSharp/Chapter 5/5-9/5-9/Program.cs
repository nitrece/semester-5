using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the real number: ");
            string r;
            r= Console.ReadLine();
            double x;
            x= double.Parse(r.ToString());
            int y = (int)x;
            Console.WriteLine("The required output is: "+y+" "+r+" "+(y+1));
            Console.ReadLine();
        }
    }
}
