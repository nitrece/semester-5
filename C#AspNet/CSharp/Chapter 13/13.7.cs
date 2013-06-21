using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class person
{
   
    string name;
    string sex;
    int age;
    public void input()
    {
        Console.WriteLine();
        Console.WriteLine("ENTER NAME , SEX & AGE IN ORDER ");
        name = Console.ReadLine();
        sex = Console.ReadLine();
        age = int.Parse(Console.ReadLine());
    }
    public void display()
   {
       Console.WriteLine("NAME IS "+ name);
       Console.WriteLine("SEX IS "+ sex);
       Console.WriteLine("AGE IS "+age);
   }

}
class employee : person
{
    string c;
    public void input1()
    {
        input();
        Console.WriteLine("ENTER  EMPLOYEE'S CODE");
       c= Console.ReadLine();
    }
    public void display1()
    {
        display();
        Console.WriteLine("EMPLOYEE'S CODE IS "+c);

    }
    
}
class specialist : employee
{
    string s;
    public void input2()
    {
        input();
       
        Console.WriteLine("ENTER  EMPLOYEE'S SPECIALISATION");
        s = Console.ReadLine();
    }
    public void display2()
    {
        Console.WriteLine();
        display1();
        Console.WriteLine("EMPLOYEE'S SPECIALISATION IS " + s);

    }
    
}

class A
{
    public static void Main()
    {

        employee e = new employee();
        specialist s = new specialist();

        int i = 0;
        for(i=0;i<3;i++)
        {
        Console.WriteLine("ENETR DETAILS OF AN ORDINARY PEOPLE "+(i+1));
        e.input1();
        Console.WriteLine("ENETR DETAILS OF AN SPECIAL PEOPLE "+(i+1));
        s.input2();
        }
        Console.WriteLine();
        Console.WriteLine();
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine(" DETAILS OF ORDINARY OEOPLE IS " + (i + 1));
            e.display1();
            Console.WriteLine(" DETAILS OF SPECIAL POEOPLE IS " + (i + 1));
            s.display2();
        }
    }    
    
}
