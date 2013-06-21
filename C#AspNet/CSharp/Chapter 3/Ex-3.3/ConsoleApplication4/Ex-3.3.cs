using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Csharp
    {
        static void Main(string[] args)
        {
            Console.Write("C Sharp ");
            Programming obj=new Programming();
            obj.display();
            Console.ReadKey(false);
        }
    }
    class Programming
    {
        public void display()
        {
            Console.Write("Programming");
        }
    }
}
