using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_3
{
    class Program
    {
        int x = 10;
        static int y = 20;
        public static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(this.x);
            Console.WriteLine(Scope.y);
        }
    }
}
