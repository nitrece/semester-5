using System;


namespace Program_11_5
{
    struct Mail
    {
        public string name, street, city;
        public short DNum;
        public int PC;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mail m = new Mail();
            Console.WriteLine("Enter name : ");
            m.name = Console.ReadLine();
            Console.WriteLine("Enter door number : ");
            m.DNum = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter street : ");
            m.street = Console.ReadLine();
            Console.WriteLine("Enter city : ");
            m.city = Console.ReadLine();
            Console.WriteLine("Enter PIN code : ");
            m.PC = int.Parse(Console.ReadLine());
            Console.WriteLine("Name = " + m.name);
            Console.WriteLine("Address : " + m.DNum + "\n" + m.street + "\n" + m.city + "\n" + m.PC);

        }
    }
}
