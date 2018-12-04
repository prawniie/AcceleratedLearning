using System;
using System.Collections.Generic;

namespace _10._4.Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numList = AskUserForNumbers();
            CalculateMean(numList);
            CalculateMedian(numList);
        }

        private static List<decimal> AskUserForNumbers()
        {
            string input;
            List<decimal> numList = new List<decimal>();

            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input=="exit")
                {
                    break;
                }

                decimal number = decimal.Parse(input);
                numList.Add(number);
            }

            return numList;
        }

        private static void CalculateMean(List<decimal> numList)
        {
            Console.WriteLine("Calculating mean..");

        }

        private static void CalculateMedian(List<decimal> numList)
        {
            Console.WriteLine("Calculating median..");
        }
    }
}
