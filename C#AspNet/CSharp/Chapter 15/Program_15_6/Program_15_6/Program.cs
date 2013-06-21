using System;

namespace Program_15_6
{
    class MyString
    {
        string s;
        public static MyString operator +(MyString a, MyString b)
        {
            MyString c = new MyString();
            c.s = string.Concat(a.s, b.s);
            return c;
        }
        public static bool operator ==(MyString a, MyString b)
        {
            return (a.s == b.s);
        }
        public static bool operator -(MyString a)
        {
            return (a.s == "");
        }
        public static bool operator !=(MyString a, MyString b)
        {
            return (!(a.s == b.s));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
