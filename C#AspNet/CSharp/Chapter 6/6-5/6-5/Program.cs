using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10];
            string[] a1=new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter mark of student " + (i+1) + ": ");
                a1[i] = Console.ReadLine();
                a[i]=double.Parse(a1[i]);
            }
            Console.WriteLine("The students having marks in the range 0-40 are: ");
            for (int i = 0; i < 10; i++)
            {
                if (a[i] >= 0 && a[i] <= 40)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("The students having marks in the range 41-60 are: ");
            for (int i = 0; i < 10; i++)
            {
                if (a[i] >= 41 && a[i] <= 60)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("The students having marks in the range 61-80 are: ");
            for (int i = 0; i < 10; i++)
            {
                if (a[i] >= 61 && a[i] <= 80)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("The students having marks in the range 81-100 are: ");
            for (int i = 0; i < 10; i++)
            {
                if (a[i] >= 81 && a[i] <= 100)
                {
                    Console.WriteLine(a[i]);
                }
            }
                Console.ReadLine();
        }
    }
}
