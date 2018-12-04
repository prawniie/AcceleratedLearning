using System;
using System.Text.RegularExpressions;

namespace Module8._3
{

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string animalString = AskForAnimals();

                try
                {
                string[] animals = ParseAnimals(animalString);
                PrintAnimals(animals);
                    break;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something unexpected happened");
                    Console.WriteLine(e.Message);
                }
            }
        }


        private static string AskForAnimals()
        {

            Console.Write("Enter a list of animals: ");
            string animalString = Console.ReadLine();
            return animalString;
        }

        private static string[] ParseAnimals(string animalString)
        {

            CheckIfStringIsEmpty(animalString);
            
            string[] animals = animalString.Split(',');

            //Tar bort mellanslag "Clean up array"
            for (var i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i].Trim();
            }            

            //Kollar om något djur innehåller mer än 20 bokstäver
            foreach (var animal in animals)
            {
                if (animal.Length>20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"{animal} has more than 20 letters!");
                }
            }

            //Kollar om något djur innehåller andra tecken än bokstäver
            foreach (var animal in animals)
            {
                string pattern = @"^[a-zåäöA-ZÅÄÖ]+$";
                Match match = Regex.Match(animal, pattern);

                if (!match.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"{animal} contains invalid letters!");
                }
            }
            Console.ResetColor();

            //ERIKAS SÄTT ATT SKRIVA =) 
            //Regex reg = new Regex(@"^[a-zA-Z]+$");

            //if (!reg.Match(animalString).Success)
            //{
            //    throw new ArgumentException($"{animal} contains invalid letters!");

            //}

            return animals;

        }

        private static void CheckIfStringIsEmpty(string animalString)
        {
            if (string.IsNullOrWhiteSpace(animalString))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("Animal string does not contain any letters!");
            }
            Console.ResetColor();
        }

        private static void PrintAnimals(string[] animals)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThere are {animals.Length} animals in your list:\n");

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"* {animals[i]}");
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
