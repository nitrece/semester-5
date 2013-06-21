using System;

namespace Program_15_4
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
        public static bool operator ==(Vector m, Vector n)
        {
            bool b1 = ((m.a == n.a) && (m.b == n.b) && (m.c == n.c));
            return b1;
        }
        public static bool operator !=(Vector m, Vector n)
        {
            bool b2 = (m == n);
            return b2;
        }
    }
    class Program
    {
        static void Main()
        {
        }
    }
}
