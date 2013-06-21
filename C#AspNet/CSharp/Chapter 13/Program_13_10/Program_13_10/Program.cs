using System;

namespace Program_13_10
{
    class Staff
    {
        protected string name;
        protected int code;
        public Staff()
        {
            Console.WriteLine("Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Code : ");
            code = int.Parse(Console.ReadLine());
        }
    }
    class Teacher : Staff
    {
        string sub, pub;
        public Teacher()
        {
            Console.WriteLine("Enter subject : ");
            sub = Console.ReadLine();
            Console.WriteLine("Enter publication ");
            pub = Console.ReadLine();
        }
    }
    class Typist : Staff
    {
        short speed;
        public Typist()
        {
            Console.WriteLine("Enter speed :");
            speed = short.Parse(Console.ReadLine());
        }
    }
    class Officer : Staff
    {
        public Officer()
        {
            char g;
            Console.WriteLine("Enter grade ");
            g = char.Parse(Console.ReadLine());
        }
    }
    class Regular : Typist
    { }
    class Casual : Staff
    {
        float f;
        public Casual()
        {
            Console.WriteLine("Enter daily wages ");
            f = float.Parse(Console.ReadLine());
        }
    }


    class Program
    {
        static void Main()
        {
        }
    }
}
