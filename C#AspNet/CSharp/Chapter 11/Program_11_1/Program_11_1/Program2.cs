using System;

namespace Program_11_1
{
    struct DateOfBirth
    {
        public int date, month, year;
        public DateOfBirth(int d, int m, int y)
        {
            date = d; month = m; year = y;
        }
        public void Display()
        {
            Console.WriteLine("My date of birth is " + date + "/" + month + "/" + year);
        }
    }
    class Program
    {
        static void Main()
        {
            DateOfBirth dob = new DateOfBirth(20,7,12);
            dob.Display();
        }
    }
}
