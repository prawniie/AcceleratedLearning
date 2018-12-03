using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Module3
{
    class Program
    {
        public static string name;
        public static int number;


        static void Main(string[] args)
        {

            //CalculateSleep();
            //RepeatName();
            //DisplayName();
            //CheckNumber();
            //GuessNumber();
            //HelloUser();

            //CheckNumber2();
            //ReadText();

        }

        private static void ReadText()
        {
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";

            System.IO.File.WriteAllText(@"yyy.txt", text);

            string text2 = File.ReadAllText(@"xxxx.txt");
            Console.WriteLine(text2);
        }

        private static void CheckNumber2()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number to compare to: ");
            int number2 = int.Parse(Console.ReadLine());

            //string result = (number > number2) ? $"{number} is larger than {number2}" : $"{number} is smaller than {number2}";
            string result = (number > number2) ? $"{number} is larger than {number2}" : (number == number2) ? $"The numbers are equal" : (number < number2) ? $"{number} is smaller than {number2}" : "Something unexpected happened..";


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void HelloUser()
        {
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            string message;

            if (gender.ToLower() == "male")
            {
                if (age > 80)
                    message = "\nYou are an old, old man";

                else if (age < 80 && age > 30)
                    message = "\nYou are a man in your best years";
                else
                    message = "\nYou are only a young boy..";
            }
            else if (gender.ToLower() == "female")
            {
                if (age > 80)
                   message = "\nYou are an old, old lady";

                else if (age < 80 && age > 30)
                    message = "\nYou are a woman in your best years";
                else
                    message = "\nYou are only a young girl..";

            Console.WriteLine(message);
            }



        }

        private static void GuessNumber()
        {

            //int number2 = new Random().Next(2, 10);
            Random random = new Random(100);
            int number = random.Next(1, 100);

            int guessedNumber;
            int numberOfGuesses = 0;

            Console.WriteLine("Welcome to my guessing game!");

            do
            {
                Console.ResetColor();
                Console.Write("Enter a number between 1 and 100: ");
                guessedNumber = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (guessedNumber == number)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nYou guessed correctly! It took you {numberOfGuesses} tries.");
                    break;
                }
                else if (guessedNumber > number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your guessed number is larger than the number.");
                }
                else if (guessedNumber < number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your guessed number is smaller than the number.");
                }

            } while (numberOfGuesses < 6);


            Console.ResetColor();
            Console.WriteLine($"\nThe correct number is: {number}");
        }

        private static void CheckNumber()
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number to compare to: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            if (number > number2)
            {
                Console.WriteLine($"{number} is greater than {number2}");
            }
            else if (number == number2)
            {
                Console.WriteLine($"{number} is equal to {number2}.");
            }
            else
            {
                Console.WriteLine($"{number} is less than {number2}.");
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        private static void DisplayName()
        {

            Console.Write("Enter names in a list (like Maria, Peter, Ganondorf): ");
            string input = Console.ReadLine();
            //string[] names = input.Split(',');
            string[] names = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


            int counter = 1;

            foreach (string name in names)
            {
                if (name.Trim() != "Zelda")
                {
                    Console.WriteLine($"[{counter}] {name.Trim()} Andersson");
                    counter++;
                }
                else if (name.Trim() == "Zelda" && input.Contains("AllowZelda"))
                {
                    Console.WriteLine($"[{counter}] {name.Trim()} Andersson");
                    counter++;
                }
                else
                    break;
            }
        }

        private static void RepeatName()
        {

            string x = "abcd";
            var y = new string((x.Reverse()).ToString());

            EnterName();
            CheckNameLength();

            EnterNumber();
            CheckSizeOfNumber();
            LoopName();
            // PresentInRows(); FÅR INTE RIKTIGT TILL DET...

        }

        private static void EnterName()
        {
            Console.ResetColor();
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            CheckNameLength();

        }

        private static void CheckNameLength()
        {
            char[] nameArray = name.ToCharArray();

            if (nameArray.Length > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your name has to be between shorter than 10 letters.");
                EnterName();
            }
            else if (nameArray.Length < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your name has to be longer than 2 letters.");
                EnterName();
            }

        }

        private static void EnterNumber()
        {
            Console.ResetColor();
            Console.Write("Times to repeat: ");
            number = int.Parse(Console.ReadLine());
            CheckSizeOfNumber();
        }

        private static void CheckSizeOfNumber()
        {
            if (number > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your number is too big!");
                EnterNumber();
            }
            else if (number < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your number has to be larger than 1.");
                EnterNumber();
            }
        }

        private static void LoopName()
        {
            /*int count = 0;
            Console.WriteLine();


            // VANLIG WHILE LOOP
            while (count < number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your name is {name}!");
                count++;
            }
            */

            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your name is {name}!");
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        private static void PresentInRows()
        {
            //name = String.Format("|{0,0}    {0,0}   {0,0}   {0,0}|", name);
            //Console.WriteLine(name);

            Console.Write("Enter number of columns: ");
            int column = int.Parse(Console.ReadLine());

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());



            for (int i = 1; i <= column; i++)
            {
                Console.Write($"{name}\n");

                for (int j = 1; j <= rows; j++)
                {
                    Console.Write(name);
                }
            }
        }
        //DO-WHILE LOOP
        /*
        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your name is {name}!");
            count++;
        } while (count<5);
        */

        private static void CalculateSleep()
        {

            Console.Write("When did you go to sleep? ");
            int toSleep = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wokeUp = int.Parse(Console.ReadLine());

            int sleepTime;

            if (toSleep > wokeUp)
                sleepTime = wokeUp + (24 - toSleep);
            else
                sleepTime = wokeUp - toSleep;

            Console.WriteLine($"\nYou have slept {sleepTime} hours. \n");

        }
    }
}
