using System;
using System.Collections.Generic;

namespace Module12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Bruce Dickinson", "Ozzy Osbourne", "Jim Morrison" };
            List<string> rockstarsList = new List<string>() { "Bruce Dickinson", "Ozzy Osbourne", "Jim Morrison" };

            DisplayArrayOfRockstars(rockstarsArray);
            DisplayListOfRockstars(rockstarsList);

            DisplayRockstars(rockstarsArray);
            DisplayRockstars(rockstarsList);
        }

        private static void DisplayListOfRockstars(List<string> rockstarsList)
        {
            Console.WriteLine("My rockstars: (list)");
            PrintRockstarsName(rockstarsList);
        }

        private static void DisplayArrayOfRockstars(string[] rockstarsArray)
        {
            Console.WriteLine("My rockstars: (array)");
            PrintRockstarsName(rockstarsArray);
        }

        private static void DisplayRockstars(IEnumerable<string> rockstars)
        {
            Console.WriteLine("My rockstars: (ienumerable)");
            PrintRockstarsName(rockstars);
        }

        private static void PrintRockstarsName(IEnumerable<string> rockstars)
        {
            Console.WriteLine();
            foreach (var rockstar in rockstars)
            {
                Console.WriteLine("* " + rockstar);
            }
            Console.WriteLine();
        }
    }
}
