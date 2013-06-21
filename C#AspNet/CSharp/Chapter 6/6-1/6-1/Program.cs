using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, s=0;
        ajit: 
            if (i <= 20 )
            {
                if(i%2==1)
                s = s + i;
                i++;
                goto ajit;
            }
        Console.WriteLine("sum= " + s);
        Console.ReadLine();

        }
    }
}
