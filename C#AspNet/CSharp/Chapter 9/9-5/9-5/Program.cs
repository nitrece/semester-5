using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count={0,0,0,0,0,0};
            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter vote(1-5): ");
                n[i] = int.Parse(Console.ReadLine());
            }
                for (int i = 0; i < 10; i++)
                {
                    if (n[i] == 1)
                        count[0]++;
                    else
                        if (n[i] == 2)
                            count[1]++;
                        else
                            if (n[i] == 3)
                                count[2]++;
                            else
                                if (n[i] == 4)
                                    count[3]++;
                                else
                                    if (n[i] == 5)
                                        count[4]++;
                                    else
                                        count[5]++;
                }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The votes given to candidate " + (i + 1) + " is: " + count[i] + ".");
            }
            Console.WriteLine("Spoilt votes= " + count[5]);
        }
    }
}
