using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_15
{
    class Program
    {
        static int mul(ref int x, ref int y, ref int z)
        {
            if (x < y)
                if (x < z)
                    return x;
                else
                    return z;
            else
                if (y < z)
                    return y;
                else return z;
        }
        static void Main(string[] args)
        {
            int z = 6, x = 2, y = 3;
            int ans = mul(ref x, ref y, ref z);
            Console.WriteLine("ans= " + ans);
        }
    }
}
