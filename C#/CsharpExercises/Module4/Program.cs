using System;
using System.Collections.Generic;

namespace Module4
{
    class Program
    {

            static string[] names;
            static bool namesAreValid;

        static void Main(string[] args)
        {


                char separator = AskForSeparator();
            do
            {
                string response = EnterNames();
                names = CreateList(response, separator);
                CleanUpArray(names);
                namesAreValid = ValidateNames(names);
            } while (namesAreValid == false);

            PrintNames(names);


            Console.WriteLine();
            Console.ResetColor();
        }


        private static char AskForSeparator()
        {
            char separator;
            bool validSeparator = true;
            string input;

            do
            {
            Console.ResetColor();
            Console.Write("Which separator do you want to use? ");
            input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter one character.");
                    validSeparator = false;
                }
                else if (input.Length > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter only ONE character.");
                    validSeparator = false;
                }

                else if (input.Length == 1)
                {
                    char inputChar = char.Parse(input);
                    bool isLetter = char.IsLetter(inputChar);

                    if (isLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You cannot use a letter!");
                        validSeparator = false;
                    }
                    else
                        validSeparator = true;
                }
                else
                {
                    validSeparator = true;
                }

            } while (validSeparator == false);

              separator = char.Parse(input);
              return separator;
        }

        private static string EnterNames()
        {
            Console.ResetColor();
            Console.Write("Enter a list of names: ");
            string response = Console.ReadLine();
            return response;
        }

        private static string[] CreateList(string response, char separator)
        {
            string[] names = response.Split(separator);

            return names;
        }

        private static void CleanUpArray(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim();
            }
        }

        private static bool ValidateNames(string[] names)
        {

            foreach (var name in names)
            {
                if (name.Length == 0) //(string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The list must not be empty.");
                    namesAreValid = false;
                }
                else if (name.Length < 2 || name.Length >9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Names must be more than 2 and less than 9 letters long.");
                    namesAreValid = false;
                }
                else
                {
                    namesAreValid = true;
                }
                
            }   

            return namesAreValid;
        }

        private static void PrintNames(string[] names)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine($"*** SUPER-{name.ToUpper()} ***");
            }
        }
    }
}
