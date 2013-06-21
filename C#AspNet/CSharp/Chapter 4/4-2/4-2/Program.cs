using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            int m;
            x = 75.86f;
            y = 43.48f;
            string a=x.ToString();
            string b =y.ToString();
            m =int.Parse(a)+int.Parse(b);
            Console.WriteLine(x.ToString()+" "+y.ToString());
            Console.ReadLine();
        }
    }
}
