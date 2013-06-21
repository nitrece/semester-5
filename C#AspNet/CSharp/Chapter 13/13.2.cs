using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class animal
{
    string name;
    int age;
    public void info(string s, int a)
    {
        name = s;
        age = a;
        Console.WriteLine("NAME IS  " + name);
        Console.WriteLine("AGE OF IT IS  " + age);
    }
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
}
class A
{
    public static void Main()
    {

        cat c = new cat();
        dog d = new dog();
        c.info("tom", 5);
         d.info("bruce", 6);
         c.Cinfo("tom", 5);
        d.Dinfo("bruce", 6);
    }

}
