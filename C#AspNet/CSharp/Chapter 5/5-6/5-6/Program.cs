using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            Console.WriteLine("Enter the price in rupees: ");
            string a = Console.ReadLine();
            price = double.Parse(a);
            Console.WriteLine("The Price in paise is: " + (price * 100));
            Console.ReadLine();
        }
    }
}
