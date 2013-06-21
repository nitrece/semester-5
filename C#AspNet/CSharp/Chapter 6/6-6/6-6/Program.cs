using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int math, phy, chem;
            string m, p, c;
            Console.WriteLine("Enter marks in mathematics: ");
            m = Console.ReadLine();
            Console.WriteLine("Enter marks in physics: ");
            p = Console.ReadLine();
            Console.WriteLine("Enter marks in chemistry: ");
            c = Console.ReadLine();
            math = int.Parse(m);
            phy = int.Parse(p);
            chem = int.Parse(c);
            if(math>=60&&phy>=50&&chem>=40&&((math+phy+chem)>=200||(math+phy)>=150))
            {
                Console.WriteLine("The student is eligible for admission!!");
            }
            else
                Console.WriteLine("The student is not eligible for admission!!");
            Console.ReadLine();
        }
    }
}
