using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 100;
            object om = m;
            m = 20;
            Console.WriteLine(m+" ");
            Console.WriteLine(om+" ");
            int n = (int)om;
            Console.WriteLine(n+" ");
            Console.ReadLine();
        }
    }
}
