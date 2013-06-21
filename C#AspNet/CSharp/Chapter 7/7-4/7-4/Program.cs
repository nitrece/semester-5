using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,x=1,y=1;
            Console.WriteLine("Enter m: ");
            string m1 = Console.ReadLine();
            m = int.Parse(m1);
            m -= 2; ;
            Console.Write(x+" ");
            do
            {
                Console.Write(y + " ");
                int temp = y;
                y = x + y;
                x = temp;
            } while ((m--) > 0);
            Console.ReadLine();
        }
    }
}
