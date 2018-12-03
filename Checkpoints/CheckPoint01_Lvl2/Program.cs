using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint01_Lvl2
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] commands = AskUserForInput();
            bool upSideDown = CheckCommandsForDisplay(commands);

            if(upSideDown)
            {
                List<int> triangleNumbers = CreateListOfCommands(commands);
                PrintTriangle(triangleNumbers);
            }
            else
            {
                List<int> triangleNumbers = CreateListOfCommands(commands);
                PrintTriangleUpsideDown(triangleNumbers);
            }


        }

        private static string[] AskUserForInput()
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            Console.ResetColor();

            string[] commands = input.Split('-');
            return commands;
        }

        private static bool CheckCommandsForDisplay(string[] commands)
        {
            foreach (string number in commands)
            {
                if (number.Contains("A"))
                {
                    Console.WriteLine("Printing triangle as usual");
                    return true;
                    //PrintTriangle(triangleNumbers);
                }

                else if (number.Contains("B"))
                {
                    Console.WriteLine("Printing triangle upside down");
                    return false;
                    //PrintTriangleUpsideDown(triangleNumbers);
                }

                else
                {
                    Console.WriteLine("Sorry something went wrong.");
                    return true;
                }
            }

            return true;
        }

        private static List<int> CreateListOfCommands(string[] commands)
        {

            foreach (string command in commands)
            {
            StringBuilder sb = new StringBuilder(command);
            sb.Remove(1,1);
            //command = sb.ToString();
                
            }

            int x;
            List<int> triangleNumbers = new List<int>();

            foreach (var number in commands)
            {
                x = int.Parse(number);
                triangleNumbers.Add(x);
            }

            return triangleNumbers;
        }

        private static void PrintTriangleUpsideDown(List<int> triangleNumbers)
        {

            foreach (int number in triangleNumbers)
            {
                Console.WriteLine();

                for (int i = 1; i <= number; i++)
                {
                    for (int j = number; j >= i; j--)
                    {
                        Console.Write($"*");
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        private static void PrintTriangle(List<int> triangleNumbers)
        {

            foreach (int number in triangleNumbers)
            {
                Console.WriteLine();

                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"*");
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
