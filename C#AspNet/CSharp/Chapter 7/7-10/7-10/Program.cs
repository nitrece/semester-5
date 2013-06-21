using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            foreach (int i in a)
            {
                Console.Write(i + " ");
                if (i > 4)
                    break;
                if (i > 3)
                    goto ajit;
                else continue;
            ajit: ;
            }
        }
    }
}
