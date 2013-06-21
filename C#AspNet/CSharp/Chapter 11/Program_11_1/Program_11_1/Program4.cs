using System;

namespace Program_11_1
{
    struct Student
    {
        public string name;
        public struct DOB
        {
            public short date, month, year;
        }
        public float marks;
    }
    class Program
    {
        static void Main()
        {
            Student s = new Student();
            Console.WrtieLine("Enter name : ");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter day of date of birth : ");
            s.DOB.date = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter month : ");
            s.DOB.month = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter year : ");
            s.DOB.year = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks : ");
            s.marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Name : " + s.name);
            Console.WriteLine("Date of birth : " + s.DOB.date + " / " + s.DOB.month + " / " + s.DOB.year);
            Console.WriteLine("Marks : " + s.marks);
        }
    }
}
