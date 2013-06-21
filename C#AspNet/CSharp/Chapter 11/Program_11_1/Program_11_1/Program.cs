using System;

namespace Program_11_1
{
    struct DateOfBirth
    {
        public int date, month, year;
    }
    class Program
    {
        static void Main()
        {
            DateOfBirth dob = new DateOfBirth();
            dob.date = 20;
            dob.month = 07;
            dob.year = 2012;
            Console.WriteLine("My date of birth is " + dob.date + "/" + dob.month + "/" + dob.year);
        }
    }
}
