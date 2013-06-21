using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_12
{
    class Program
    {
        static void mul(int x, int y, out int z)
        {
            z = x * y;
        }
        static void Main(string[] args)
        {
            int z;
            mul(3, 6, out z);
            Console.WriteLine("z= " + z);
        }
    }
}
