using System;

namespace Program_15_1
{
    class Float
    {
        float f;
        public static Float operator +(Float a, Float b)
        {
            Float c = new Float(); c.f = (a.f + b.f); return c;
        }
        public static Float operator -(Float a, Float b)
        {
            Float c = new Float(); c.f = (a.f - b.f); return c;
        }
        public static Float operator *(Float a, Float b)
        {
            Float c = new Float(); c.f = (a.f * b.f); return c;
        }
        public static Float operator /(Float a, Float b)
        {
            Float c = new Float(); c.f = (a.f / b.f); return c;
        }
        public override string ToString()
        {
            return this.ToString();
        }
        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
    
