using System;

namespace Program_13_12
{
    class Shape
    {
        protected double a, b;
        public void Set(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public virtual void Area()
        { }
    }
    class Triangle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("The area of the triangle is : " + (0.5 * a * b));
        }
    }
    class Rectangle : Shape
    {
        //Area() method removed.
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the height and base of Triangle. ");
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            Triangle t = new Triangle();
            t.Set(d1, d2);
            t.Area();
            Console.WriteLine("Enter the length and breadth of the Rectangle. ");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle();
            r.Set(d1, d2);
            r.Area();
        }
    }
}
