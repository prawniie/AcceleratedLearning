using System;
using System.Collections.Generic;

namespace Checkpoint01
{
    class Program
    {

        static void Main(string[] args)
        {

            string command = AskUserForCommand();
            List<int> listOfCommands = CreateListOfCommands(command);
            PrintTriangle(listOfCommands);
            //PrintTriangleUpsideDown(listOfCommands); //Bonus from lvl2

        }

        private static string AskUserForCommand()
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string command = Console.ReadLine();
            Console.ResetColor();

            return command;
        }

        private static List<int> CreateListOfCommands(string command)
        {
            string[] commands = command.Split('-');

            List<int> listOfCommands = new List<int>();
            int x;

            foreach (var number in commands)
            {
                x = int.Parse(number);
                listOfCommands.Add(x);
            }

            return listOfCommands;
        }

        private static void PrintTriangle(List<int> listOfCommands)
        {

            foreach (int number in listOfCommands)
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
            Console.WriteLine();
        }

        private static void PrintTriangleUpsideDown(List<int> listOfCommands)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("X-mas bonus: Displaying your triangles upside down!\n");
            Console.ResetColor();

            foreach (int number in listOfCommands)
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
    }
}
