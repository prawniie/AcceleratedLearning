using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayingWithRegex();

            //WhatsYourName();

            //WhatsYourName_WithTypes();

            //EnterFruit();

            //FruitList(); BONUS

            //HoursOfSleep(); BONUS

            //ReadAndWriteFromFile(); BONUS

        }

        private static void PlayingWithRegex()
        {
            string zipCode = "444 44";
            string pattern = @"\d\d\d\s\d\d";

            Match match = Regex.Match(zipCode, pattern);

            if (match.Success)
            {
                Console.WriteLine("Valid zipcode");
            }
            else
            {
                Console.WriteLine("Unvalid zipcode!");
            }
        }

        private static void ReadAndWriteFromFile()
        {
            //string text = "Det var en gång en liten hund som hette Yoshi. Han älskade att lägga sig på rygg i gräset och lukta på blommorna.";

            //File.WriteAllText(@"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module3\Yoshi.txt", text);

            string text2 = File.ReadAllText(@"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module3\Erke.txt");

            if (text2.Contains("finsk"))
            {
                Console.WriteLine("Hittade en finsk lapphund!");
            }

            //Console.WriteLine(text2);

        }

        private static void HoursOfSleep()
        {
            Console.Write("When did you go to bed? ");
            int bedTime = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wakeTime = int.Parse(Console.ReadLine());

            int hoursOfSleep;

            if (bedTime > 20)
            {
                hoursOfSleep = (24 - bedTime) + wakeTime;
            }
            else
                hoursOfSleep = wakeTime - bedTime;

            string message;

            if (hoursOfSleep == 3)
                message = "You have only slept three hours. Go back to bed!";
            else if (hoursOfSleep == 14)
                message = "You have slept 14 hours. That's a lot!";
            else
                message = $"You have slept well ({hoursOfSleep} hours).";

            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }

        private static void FruitList()
        {
            Console.Write("How many fruits do you want to enter? ");
            int numberOfFruits = int.Parse(Console.ReadLine());

            List<string> fruitList = new List<string>();

            for (int i = 0; i < numberOfFruits; i++)
            {
                Console.Write("Please enter a fruit: ");
                string fruit = Console.ReadLine();
                fruitList.Add(fruit);
            }

            Console.ForegroundColor = ConsoleColor.Green;

            int numberOfContains = 0;

            foreach (string fruit in fruitList)
            {
                if(fruit.Contains("range"))
                {
                    numberOfContains++;
                }
            }

            Console.WriteLine($"Your fruits had {numberOfContains} instances of \"range\".");

            Console.WriteLine("\nYou entered the following fruits (sorted alphabetically): \n");
            fruitList.Sort();

            foreach (string fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
            Console.ResetColor();

        }

        private static void EnterFruit()
        {
            /*
            Console.Write("Bonus: Enter a first fruit: ");
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            Console.WriteLine(text);
            */

            Console.Write("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();


            if (fruit1.ToLower() == "apple")
                Console.Beep(3000, 500);
            else
                Console.Beep(500, 500);

            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            string output = string.Format("You entered three fruits: {0}, {1}, {2}", fruit1.Trim().ToLower(), fruit2.Trim().ToLower(), fruit3.Trim().ToLower());
            Console.WriteLine(output);

            Console.WriteLine("You entered three fruits: {0}, {1}, {2}", fruit1.Trim(), fruit2.Trim(), fruit3.Trim());
            Console.WriteLine($"You entered three fruits: {fruit1.Trim()}, {fruit2.Trim()}, {fruit3.Trim()}"); //Interpolation, rekommenderas av Oscar
            Console.WriteLine("You entered three fruits: " + fruit1.Trim() + ", " + fruit2.Trim() + ", " + fruit3.Trim());

            Console.WriteLine();
            Console.ResetColor();
        }


        private static void WhatsYourName_WithTypes()
        {

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            if (name == "Rebecka")
                Console.Beep(3000, 500);

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine()); //när använda int.Parse vs Convert.ToInt32??

            Console.Write("What is your favorite character? ");
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is: " + name);

            int untilRetirement = 65 - age;
            bool userLikesNumbers = char.IsNumber(c);

            Console.WriteLine("You have " + untilRetirement + " years until retirement");

            if (userLikesNumbers)
            {
                Console.WriteLine("You like numbers ");
            }
            else
            {
                Console.WriteLine("You like letters ");
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        private static void WhatsYourName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            string age = Console.ReadLine();

            Console.Write("What is your favorite letter? ");
            string letter = Console.ReadLine();

            Console.Write("What is your video game? ");
            string videoGame = Console.ReadLine();

            Console.WriteLine("\nThank you!\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Your favorite letter is " + letter);
            Console.WriteLine("Your favorite video game is " + videoGame);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
