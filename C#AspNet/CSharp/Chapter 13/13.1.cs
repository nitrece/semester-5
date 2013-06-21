using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

sealed class animal
{
    string name;
    int age;
    public void info(string s, int a)
    {
         name=s;
         age=a;
        Console.WriteLine("NAME IS  "+name);
        Console.WriteLine("AGE OF IT IS  "+age);
    }
}
 class cat : animal 
{
}
 class dog : animal
{
}
class A 
{
    public static void Main()
    {
        
        cat c = new cat();
        dog d = new dog();
        c.info("tom", 5);
        d.info("bruce", 6);
    }
  
}
