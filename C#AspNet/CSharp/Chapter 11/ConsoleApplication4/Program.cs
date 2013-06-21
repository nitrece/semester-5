using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Structures_and_Enumerations.Problem1.Exec();
            Console.ReadKey();
        }
    }
}

namespace Structures_and_Enumerations
{
    class Problem1
    {
        struct Date_of_Birth
        {
            public int Day;
            public int Month;
            public int Year;
        }

        public static void Exec()
        {
            string Str;
            Date_of_Birth DOB;
            do
            {
                Console.WriteLine("Welcome individual!");
                Console.Write("Enter your birth day: ");
                Str = Console.ReadLine();
                if (Str == "") break;
                DOB.Day = int.Parse(Str);
                Console.Write("Enter your birth month: ");
                DOB.Month = int.Parse(Console.ReadLine());
                Console.Write("Enter your birth year: ");
                DOB.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("My date of birth is {0:D2}/{1:D2}/{2:D2}\n", DOB.Day, DOB.Month, DOB.Year);
            } while (true);
        }
    }
    class Problem2
    {
        struct Date_of_Birth
        {
            public int Day;
            public int Month;
            public int Year;
            public Date_of_Birth(string day, string month, string year)
            {
                Day = int.Parse(day);
                Month = int.Parse(month);
                Year = int.Parse(year);
            }
            public void Display()
            {
                Console.WriteLine("My date of birth is {0:D2}/{1:D2}/{2:D2}\n", Day, Month, Year);
            }
        }

        public static void Exec()
        {
            String Day, Month, Year;
            Date_of_Birth DOB;
            do
            {
                Console.WriteLine("Welcome individual!");
                Console.Write("Enter your birth day: ");
                Day = Console.ReadLine();
                if (Day == "") break;
                Console.Write("Enter your birth month: ");
                Month = Console.ReadLine();
                Console.Write("Enter your birth year: ");
                Year = Console.ReadLine();
                DOB = new Date_of_Birth(Day, Month, Year);
                DOB.Display();
            } while (true);
        }
    }
    class Problem3
    {
        struct Student_Record
        {
            public string Name;
            public string DateOfBirth;
            public int TotalMarks;
        }
        public struct Mailing_List
        {
            public string Name;
            public string DoorNumber;
            public string Street;
            public string City;
            public long Pincode;
        }
        public struct Inventory_Record
        {
            public string ItemCode;
            public string ItemName;
            public float ItemCost;
            public long TotalItems;
        }
        struct Book_Record
        {
            public string Author;
            public string Title;
            public int PublicationYear;
            public float Cost;
        }
    }
    class Problem4
    {
        struct Date_of_Birth
        {
            public int Day;
            public int Month;
            public int Year;
            public Date_of_Birth(string day, string month, string year)
            {
                Day = int.Parse(day);
                Month = int.Parse(month);
                Year = int.Parse(year);
            }
            public void Display()
            {
                Console.WriteLine("My date of birth is {0:D2}/{1:D2}/{2:D2}", Day, Month, Year);
            }
        }
        struct Student_Record
        {
            public string Name;
            public Date_of_Birth DateOfBirth;
            public int TotalMarks;

        }

        public static void Exec()
        {
            Student_Record Student;
            String Name, Day, Month, Year;
            int TotalMarks;
            do
            {
                Console.WriteLine("Welcome Student!");
                Console.Write("Enter your Name: ");
                Name = Console.ReadLine();
                if (Name == "") break;
                Console.Write("Enter your birth day: ");
                Day = Console.ReadLine();
                Console.Write("Enter your birth month: ");
                Month = Console.ReadLine();
                Console.Write("Enter your birth year: ");
                Year = Console.ReadLine();
                Console.Write("Enter your total marks: ");
                TotalMarks = int.Parse(Console.ReadLine());
                Student.Name = Name;
                Student.DateOfBirth = new Date_of_Birth(Day, Month, Year);
                Student.TotalMarks = TotalMarks;
                Console.WriteLine("My name is {0}", Student.Name);
                Student.DateOfBirth.Display();
                Console.WriteLine("My total marks is {0}\n", Student.TotalMarks);
            } while (true);
        }
    }
    class Problem5
    {
        public static void Exec()
        {
            Problem3.Mailing_List Address;
            do
            {
                Console.WriteLine("Welcome Postman!");
                Console.Write("Enter Recipient's Name: ");
                Address.Name = Console.ReadLine();
                if (Address.Name == "") break;
                Console.Write("Enter Recipient's Door number: ");
                Address.DoorNumber = Console.ReadLine();
                Console.Write("Enter Recipient's Street: ");
                Address.Street = Console.ReadLine();
                Console.Write("Enter Recipient's City: ");
                Address.City = Console.ReadLine();
                Console.Write("Enter Recipient's Pincode: ");
                Address.Pincode = long.Parse(Console.ReadLine());
                Console.WriteLine("Print the following and paste it on the letter:");
                Console.WriteLine("To,");
                Console.WriteLine("{0},\n{1},\n{2},\n{3}\n, PIN - {4}\n", Address.Name, Address.DoorNumber, Address.Street, Address.City, Address.Pincode);
            } while (true);
        }
    }
    class Problem6
    {
        public static void Exec()
        {
            int i;
            Problem3.Inventory_Record[] Inventory = new Problem3.Inventory_Record[5];
            Console.WriteLine("Welcome Shopkeeper!\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Item {0}:", i + 1);
                Console.Write("Enter Item Code: ");
                Inventory[i].ItemCode = Console.ReadLine();
                Console.Write("Enter Item Name: ");
                Inventory[i].ItemName = Console.ReadLine();
                Console.Write("Enter Item Cost: ");
                Inventory[i].ItemCost = float.Parse(Console.ReadLine());
                Console.Write("Enter Total Items: ");
                Inventory[i].TotalItems = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.WriteLine("\nAll Items List:");
            Console.WriteLine("{0, 15}{1, 15}{2, 15}{3, 15}", "Code", "Name", "Cost", "Total Items");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0, 15}{1, 15}{2, 15}{3, 15}", Inventory[i].ItemCode, Inventory[i].ItemName, Inventory[i].ItemCost, Inventory[i].TotalItems);
            }
        }
    }
}

