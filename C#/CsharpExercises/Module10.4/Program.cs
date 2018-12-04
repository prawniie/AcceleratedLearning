using System;
using System.Collections.Generic;
using System.Linq;

namespace Module10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = AskUserForNames();
            names = SortList(names);

            if (names.Count > 3)
            {
            names = RemoveNamesFromList(names);
            }
            PrintNames(names);
        }



        private static List<string> AskUserForNames()
        {
            string name;
            List<string> names = new List<string>();

            do
            {
                Console.Write("Enter a name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                name = Console.ReadLine();
                Console.ResetColor();

                if (name.ToLower()!= "quit" && !string.IsNullOrWhiteSpace(name))
                {
                names.Add(name);
                }

            } while (name.ToLower() != "quit");

                return names;
        }

        private static List<string> SortList(List<string> names)
        {
            names.Sort();
            return names;
        }

        private static List<string> RemoveNamesFromList(List<string> names)
        {
            names.RemoveAt(0);
            names.RemoveAt(names.Count - 1);
            return names;
        }

        private static void PrintNames(List<string> names)
        {
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine($"Name: {name}");
            }

            Console.WriteLine();
        }
    }
}
