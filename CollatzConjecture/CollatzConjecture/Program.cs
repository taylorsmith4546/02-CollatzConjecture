using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static int GetIntegerFromConsole(string prompt)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number");
                }
            }
        }
        static void Main(string[] args)
        {
            int userNum = GetIntegerFromConsole("Enter a number:");
            int count = 0;
            int peakInt = userNum;
            int countAtPeak = 0;

            while (userNum !=1)
            {
                if (userNum % 2 == 0)
                {
                    userNum = userNum / 2;
                    count = count + 1;

                    if (userNum > peakInt)
                    {
                        peakInt = userNum;
                        countAtPeak = count;
                    }
                }
                else
                {
                    userNum = userNum * 3 + 1;
                    count = count + 1;
                    if (userNum > peakInt)
                    {
                        peakInt = userNum;
                        countAtPeak = count;
                    }

                }
            }
            Console.WriteLine("It took " + count + " steps to reach 1. The value reaches its peak at " + peakInt + " at step " + countAtPeak + ".");
            Console.ReadLine();
        }

    }
}
