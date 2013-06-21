using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class animal
{
    string name;
    int age;
    public virtual void info()
    {
         Console.WriteLine("NAME IS  " + name);
        Console.WriteLine("AGE OF IT IS  " + age);
    }
    public  void convert(string s, int a)
    {
        name = s;
        age = a;
        info();
    }
    public abstract void sound();
}
       

class cat : animal
{
    public void Cinfo(string s, int a)
    {
        Console.WriteLine();
        Console.WriteLine("DISPLAY FROM SUBCLASS 'CAT'");
        Console.WriteLine("NAME IS  " + s);
        Console.WriteLine("AGE OF IT IS  " + a);
    }
    public override void info()
    {
        Console.WriteLine();
        Console.WriteLine("MODIFIER OVERRIDE ADDED TO CLASS CAT");
        base.info();
    }

    public override void sound()
    {
        Console.WriteLine();
        Console.WriteLine(" ABSTRACT METHOD 'SOUND' IS IMPLEMENTED IN DERIVED CLASS 'CAT'");
    }
}
class dog : animal
{
    public void Dinfo(string s, int a)
    {
        Console.WriteLine();
        Console.WriteLine("DISPLAY FROM SUBCLASS 'DOG'");
        Console.WriteLine("NAME IS  " + s);
        Console.WriteLine("AGE OF IT IS  " + a);
    }
    public override void info()
    {
        Console.WriteLine();
        Console.WriteLine("MODIFIER OVERRIDE ADDED TO CLASS DOG");
        base.info();
    }
    public override void sound()
    {
        Console.WriteLine();
        Console.WriteLine(" ABSTRACT METHOD 'SOUND' IS IMPLEMENTED IN DERIVED CLASS 'DOG'");
    }
}
class A
{
    public static void Main()
    {

        cat c = new cat();
        dog d = new dog();
        c.convert("Tom", 5);
        d.convert("Bruce", 6);
        c.Cinfo("Tom", 5);
        c.sound();
        d.Dinfo("Bruce", 6);
        d.sound();

    }

}
