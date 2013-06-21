using System;

namespace Program_15_5
{
    class Vector
    {
        float a,b,c;
        public Vector(float a, float b, float c)
        {
            this.a = a; this.b = b; this.c = c;
        }
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
        public static Vector operator ==(float a, float b)
        {
            bool b1 = (a == b);
            return b1;
        }
        public static Vector operator !=(float a, float b)
        {
            bool b2 = (!(a == b));
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
