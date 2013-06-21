using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] temp = new double[31, 10];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the temperature of city"+(j+1)+" for day"+(i+1)+": ");
                    temp[i,j]=double.Parse(Console.ReadLine());
                }
            }
            double max=0,min=0;
            int imi=0,ima=0,jmi=0,jma=0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (temp[i, j] > max)
                    {
                        max = temp[i, j];
                        ima = i + 1;
                        jma = j + 1;
                    }
                    if (temp[i, j] < min)
                    {
                        min = temp[i, j];
                        imi = i + 1;
                        jmi = j + 1;
                    }
                }
            }
            Console.WriteLine("The highest temperature recorded is " + max + " in city" + jma + " on day" + ima + ".");
            Console.WriteLine("The lowest temperature recorded is " + min + " in city" + jmi + " on day" + imi + ".");
        }
    }
}
