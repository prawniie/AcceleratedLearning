using System;
using System.Collections.Generic;
using System.IO;

namespace Module3.Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessingGame();
            //ForeachStatement();
            //ForStatement();
            //WhileStatement();
            //ReadAndWrite();
            //IfStatement();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Welcome to my guessing game!");

            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 100);

            int guessedNumber;
            int numberOfGuesses = 1;

            do
            {
                Console.Write("Guess a number: ");
                guessedNumber = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (guessedNumber<number)
                {
                    Console.WriteLine("The guessed number is lower than the correct number!");
                    numberOfGuesses++;
                }
                else if (guessedNumber>number)
                {
                    Console.WriteLine("The guessed number is higher than the correct number!");
                    numberOfGuesses++;
                }

            } while (numberOfGuesses <= 6 || guessedNumber != number);


        }

        private static void ForeachStatement()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string names = Console.ReadLine();

            string[] listOfNames = names.Split(',');

            //Handle user input



            if (listOfNames.Length == 0)
            {
                Console.WriteLine("You must enter at least one name!");
            }

            foreach (string name in listOfNames)
            {
                if (name.Length<2)
                {
                    Console.WriteLine("A name must contain at least two letters!");
                }
                else if (name.Length>9)
                {
                    Console.WriteLine("A name cannot be longer than 9 letters!");
                }
            }

            //Create list of names from array
            List<string> nameList = new List<string>();

            foreach (string name in listOfNames)
            {
                nameList.Add(name);
            }

            //Sorting list of names

            //List<string> sortedList = new List<string>();
            nameList.Sort();

                int countAgain = 1;
            foreach (var name in nameList)
            {
                Console.WriteLine($"[{countAgain}] {name}");
                countAgain++;
            }

            Console.WriteLine("Which name do you want to add? ");
            string remove = Console.ReadLine();

            nameList.Remove(remove); //Removes first instance of a string
            //nameList.RemoveAt(1); //Removes item by index i

                int count = 1;
            foreach (var name in nameList)
            {
                Console.WriteLine($"[{count}] {name}");
                count++;
            }



            //Print names
            //Console.WriteLine();
            //int count = 1;
            //foreach (string name in listOfNames)
            //{
            //    Console.WriteLine($"[{count}]{name} Andersson");
            //    count++;
            //}
        }

        private static void ForStatement()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Number of rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Number of columns: ");
            int column = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            for (int i = 1; i <= row; i++)
            {
                Console.Write(name);

                for (int j = 1; j < column; j++)
                {
                Console.Write(name.PadLeft(10));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ResetColor();

        }

        private static void WhileStatement()
        {

            //Program would look like this:
            // AskUserForInput();
            //ValidateName();
            //ValidateNumber();
            //PrintName();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //If name is empty, too long or too short
            if (name.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter something!");
            }
            else if (name.Length > 9 || name.Length < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter a name between 2 and 9 letters long!");
            }


            //If times to repeat is too small or big
            Console.Write("Times to repeat: \n");
            int repeat = int.Parse(Console.ReadLine());

            if (repeat<=0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number must be more than 0!");
            }
            else if (repeat>10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number cannot be larger than 10!");
            }

            int count = 0;

            Console.ForegroundColor = ConsoleColor.Green;

            //Display in one or multiple lines
            Console.WriteLine("Do you want to display in one line?");
            string answer = Console.ReadLine();

            while (count < repeat)
            {
                if (answer.ToLower() == "yes")
                {
                    Console.Write($"Your name is {name}, ");
                    count++;
                }
                else
                {
                Console.WriteLine($"Your name is {name}");
                count++;
                }
            }

            Console.WriteLine();
            Console.ResetColor();
           
        }

        private static void ReadAndWrite()
        {
            string text = "Once upon a time, there was a dog called Yoshi.";
            File.WriteAllText(@"text.txt", text);

            string newText = File.ReadAllText(@"text.txt");
            Console.WriteLine(newText);
        }

        private static void IfStatement()
        {
            Console.Write("When did you go to bed yesterday? ");
            int bedTime = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wakeTime = int.Parse(Console.ReadLine());

            int hoursOfSleep;

            if (bedTime > wakeTime)
            {
                hoursOfSleep = (24 - bedTime) + wakeTime;
            }

            else
                hoursOfSleep = wakeTime - bedTime;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (hoursOfSleep<=6)
            {
                Console.WriteLine($"You have slept too little! {hoursOfSleep} hours");
            }
            else if (hoursOfSleep>6 && hoursOfSleep<9)
            {
                Console.WriteLine($"You have slept well. {hoursOfSleep} hours");
            }
            else
                Console.WriteLine($"You have slept too much! {hoursOfSleep} hours");

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
