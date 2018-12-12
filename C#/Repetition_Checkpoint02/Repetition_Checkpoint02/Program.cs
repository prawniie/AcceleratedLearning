using System;
using System.Collections.Generic;

namespace Repetition_Checkpoint02
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> listOfAnimals = new List<Animal>();

            //Adding dogs to list of animals 
            string dogInput = "Buster,4;Yoshi,3;Erke,5";

            string[] dogArray = dogInput.Split(';');

            foreach (var item in dogArray)
            {
                string[] nameAndAge = item.Split(',');

                var dog = new Dog();
                dog.Name = nameAndAge[0];
                dog.Age = int.Parse(nameAndAge[1]);
                listOfAnimals.Add(dog);

            }

            //Adding horses to list of Animals
            string horseInput = "Shining Star,4;Unlucky,19;Zelda,10";
            string[] horseArray = horseInput.Split(';');

            foreach (var item in horseArray)
            {
                string[] nameAndAge = item.Split(',');

                var horse = new Horse();
                horse.Name = nameAndAge[0];
                horse.Age = int.Parse(nameAndAge[1]);
                listOfAnimals.Add(horse);
            }

            //Printing out animals 
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Animal animal in listOfAnimals)
            {
                if(animal is Dog)
                {
                    Console.WriteLine($"{animal.Name} is a dog and is {animal.Age} years old");
                }
                else if (animal is Horse)
                {
                    Console.WriteLine($"{animal.Name} is a horse and is {animal.Age} years old");
                }
            }

 
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
