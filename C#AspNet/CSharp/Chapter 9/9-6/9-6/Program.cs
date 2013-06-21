using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rno = new int[3];
            double[] s1 = new double[3];
            double[] s2 = new double[3];
            double[] s3 = new double[3];
            double[] tot = {0,0,0};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Student"+(i+1));
                Console.WriteLine("Enter Roll Number: ");
                rno[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks in subject1: ");
                s1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks in subject2: ");
                s2[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks in subject3: ");
                s3[i] = double.Parse(Console.ReadLine());
                tot[i] = s1[i] + s2[i] + s3[i];
            }
            double h = s1[0]; int r = 0;
            double max = tot[0];int m=0;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("The total marks obtained by student"+(i+1)+": "+tot[i]);
                if (tot[i] > max)
                    max = tot[i];
            }
            for (int i = 0; i < 3; i++)
            {
                if(s1[i]>h)
                {
                    h=s1[i];
                    r=i+1;
                }
            }
            Console.WriteLine("The highest marks obtained in subject1 is: " + h + " student of roll number " + rno[r] + ".");
            for (int i = 0; i < 3; i++)
            {
                if (s2[i] > h)
                {
                    h = s2[i];
                    r = i + 1;
                }
            }
            Console.WriteLine("The highest marks obtained in subject2 is: " + h + " student of roll number " + rno[r] + ".");
            for (int i = 0; i < 3; i++)
            {
                if (s3[i] > h)
                {
                    h = s3[i];
                    r = i + 1;
                }
            }
            Console.WriteLine("The highest marks obtained in subject3 is: " + h + " student of roll number " + rno[r] + ".");
            Console.WriteLine("The highest total mark obtained is " + max + " by student of roll number " + rno[m] + ".");
        }
    }
}
