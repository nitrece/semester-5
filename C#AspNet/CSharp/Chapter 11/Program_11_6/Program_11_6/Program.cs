using System;
struct inventory    
    {
        public int code;
        public string name;
        public float cost;
        public static int NumberOfItems = 5;
    }

namespace Program_11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            inventory[] inv = new inventory[5];
            int i;
            for (i = 0; i < 5; ++i)
            {
                Console.WriteLine("For item " + (i + 1));
                Console.Write("enter name : ");
                inv[i].name = Console.ReadLine();
                Console.Write("enter code : ");
                inv[i].code = int.Parse(Console.ReadLine());
                Console.Write("enter cost : ");
                inv[i].cost = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Code \t   Name  \t      Cost \t     Total items ");
            for (i = 0; i < 5; ++i)
            {
                Console.WriteLine(inv[i].code + " \t " + inv[i].name + " \t " + inv[i].cost + " \t " + (i + 1));
            }
        }
    }
}
