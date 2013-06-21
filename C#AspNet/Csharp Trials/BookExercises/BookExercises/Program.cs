using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExercises
{
	class Program
	{
		public static void Main (string[] args)
		{
			Exam_Preparation.UsingList.Exec();
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

		public static void Exec ()
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
			public Date_of_Birth (string day, string month, string year)
			{
				Day = int.Parse(day);
				Month = int.Parse(month);
				Year = int.Parse(year);
			}
			public void Display ()
			{
				Console.WriteLine("My date of birth is {0:D2}/{1:D2}/{2:D2}\n", Day, Month, Year);
			}
		}

		public static void Exec ()
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
			public Date_of_Birth (string day, string month, string year)
			{
				Day = int.Parse(day);
				Month = int.Parse(month);
				Year = int.Parse(year);
			}
			public void Display ()
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

		public static void Exec ()
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
		public static void Exec ()
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
		public static void Exec ()
		{
			int i;
			Problem3.Inventory_Record[] Inventory = new Problem3.Inventory_Record[5];
			Console.WriteLine("Welcome Shopkeeper!\n");
			for (i=0 ; i < 5 ; i++)
			{
				Console.WriteLine("Item {0}:", i+1);
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
			for (i = 0 ; i < 5 ; i++)
			{
				Console.WriteLine("{0, 15}{1, 15}{2, 15}{3, 15}", Inventory[i].ItemCode, Inventory[i].ItemName, Inventory[i].ItemCost, Inventory[i].TotalItems);
			}
		}
	}
}

namespace Exam_Preparation
{
	class UsingAtTheRateKeywords
	{
		public static void Exec()
		{
			int[] @Array = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
			foreach(int @if in @Array) Console.WriteLine(@if);
		}
	}
	class PrintingBraces
	{
		public static void Exec ()
		{
			Console.WriteLine("{}");
		}
	}
	class UseOfDecimalDatatype
	{
		public static void Exec ()
		{
			decimal k = 1234.123456789M;
			Console.WriteLine("Printing k = " + k);
			Console.WriteLine("Printing k again = {0}", k);
		}
	}
	class UsingConstants
	{
		public static void Exec ()
		{
			const int pi = 3;
			const int one = 1;
			const int four = pi + one;
			Console.WriteLine(four);
		}
	}
	class BoxingAndUnboxing
	{
		public static void Exec ()
		{
			int n = 100;
			object o = n;
			int p = (int) o;
			Console.WriteLine("Original Number = {0}", n);
			Console.WriteLine("Boxed Number = {0}", o);
			Console.WriteLine("Unboxed Number = {0}", p);
		}
	}
	class UsingList
	{
		public static void Exec ()
		{
			List<int> list = new List<int>();
			ArrayList x = new ArrayList();
			string s = "abc".Substring(1, 2);
			Console.WriteLine(s);
			string[] n = new string[] {"b", "a", "c"};
			Array.Sort(n);
			Console.WriteLine("{0}, {1}, {2}", n[0], n[1], n[2]);
		}
	}
	class FormattingOutput
	{
		public static void Exec ()
		{
			Console.WriteLine("Normal Print\\");
			Console.WriteLine("This {0} is printing {1} of parameters", ':', '=');
			Console.WriteLine("");

			A = 10;
		}
		public static int A
		{
			get
			{
				return A;
			}
			set
			{
				A = value;
			}
		}
	}
}