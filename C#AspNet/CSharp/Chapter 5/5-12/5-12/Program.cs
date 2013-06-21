using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 15;
            int resultVar;
            Console.WriteLine("-Program to demonstrate the use of Decrement operator in c#-\n");
            Console.WriteLine("-var:First Decrements the value then assigns it....");
            resultVar = -var;
            Console.WriteLine("-After -var: {0}, {1}", var, resultVar);
            Console.WriteLine("\nvar-: First, assigns the value and then decrements it...");
            resultVar= var--;
            Console.WriteLine("After var-:{0},{1}",var,resultVar);
            Console.ReadLine();
        }
    }
}
