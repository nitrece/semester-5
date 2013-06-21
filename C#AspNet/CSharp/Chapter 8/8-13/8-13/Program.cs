using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_13
{
    class Program
    {
        static void mul(ref int x,ref int y, ref int z)
        {
            z = x * y;
        }
        static void Main(string[] args)
        {
            int z=0,x=3,y=6;
            mul(ref x, ref y,ref z);
            Console.WriteLine("z= " + z);
        }
    }
}
