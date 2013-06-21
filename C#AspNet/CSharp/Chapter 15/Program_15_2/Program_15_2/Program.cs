using System;

namespace Program_15_2
{
    class Vector
    {
        public Vector(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        int a, b, c;
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.a + b.a, a.b + b.b, a.c + b.c);
        }
        public static Vector operator *(Vector a, int b)
        {
            return new Vector(b * a.a, b * a.b, b * a.c);
        }
        public static Vector operator *(int a, Vector b)
        {
            return new Vector(a * b.a, a * b.b, a * b.c);
        }
        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.a * b.a, a.b * b.b, a.c * b.c);
        }
    }
    class Program
    {
        static void Main()
        {
        }
    }
}
