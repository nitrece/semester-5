using System;

namespace Program_15_7
{
    class Date
    {
        short d, m, y;
        public void Set()
        {
            Console.WriteLine("Enter date ");
            d = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter month ");
            m = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter year ");
            y = short.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Date : d " + "/ " + m + " / " + y);
        }
        public void increment()
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d == 31)
                    {
                        if (m == 12)
                        {
                            y += 1; m = 1; d = 1;
                        }
                        m += 1; d = 1;
                    }
                    d += 1;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    
                        if (d == 30)
                        {
                            m += 1; d = 1;
                        }
                        d += 1;
                        break; 
                case 2:
                    if ((y % 4) == 0)
                    {
                        if (d == 29)
                        {
                            m += 1; d = 1;
                        }
                        if (d == 28)
                        {
                            m += 1; d = 1;
                        }
                    }
                    d += 1;
                    break;
            }
        }
        public static short operator ==(Date a, Date b)
        {
            if (a.y > b.y) return 1;
            if (b.y > a.y) return -1;
            if (a.m > b.m) return 1;
            if (b.m > a.m) return -1;
            if (a.d > b.d) return 1;
            if (b.d > a.d) return -1;
            return 0;
        }
        public static short operator !=(Date a, Date b)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
