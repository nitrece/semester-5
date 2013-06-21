using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a string :");
            s = Console.ReadLine();
            int length = s.Length;
            int a = length-1;
            for (int i = length-1; i >= 0; i--) 
            {
                if (s[i].Equals(' '))
                {
                    for (int j = i+1; j<=a; j++)
                    {
                        Console.Write(s[j]);
                    }
                    Console.Write(' ');
                    a = i-1;
                }
            }
            for (int i = 0; i <= a; i++)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey(false);
        }
    }
}
