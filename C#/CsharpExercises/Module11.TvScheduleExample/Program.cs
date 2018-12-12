using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11.TvScheduleExample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Show> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();

        }
        private static List<Show> GetShowsFromTextFile()
        {
            string[] tvSchedule = File.ReadAllLines(@"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module11.TVScheduleExample\Tvtablå.txt");

            List<Show> allShows = new List<Show>();

            foreach (var item in tvSchedule)
            {
                string[] eachShow = item.Split('*');
                Show show = new Show();
                show.Channel = eachShow[0];
                show.StartTime = TimeSpan.Parse(eachShow[1]);
                show.Name = eachShow[2];
                allShows.Add(show);
            }

            return allShows;
        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {

            DisplayAllTitles(allShows);
            DisplayShowsStartingLaterThan21(allShows);
            DisplaySVT2Shows(allShows);
            CheckIfProgramExist(allShows);
            AllShowsStartingAt20(allShows);
            AllTitlesCapslock(allShows);
            AllChannels(allShows);

            //Göra metod som skriver ut alla element i en lista

        }

        private static void AllChannels(List<Show> allShows)
        {
            Console.WriteLine("\nALLA KANALER");

            foreach (string show in allShows.Select(x => x.Channel).Distinct())
            {
                Console.WriteLine(show);
            }
        }

        private static void AllTitlesCapslock(List<Show> allShows)
        {
            Console.WriteLine("\nALLA PROGRAMNAMN MED STORA BOKSTÄVER");
            var allTitlesCapslock = allShows.Select(x => x.Name.ToUpper()).ToList();

            Console.WriteLine(string.Join("\n",allTitlesCapslock));

        }

        private static void AllShowsStartingAt20(List<Show> allShows)
        {
            Console.WriteLine("\nALLA PROGRAM SOM BÖRJAR KL 20.00");
            var showsAt20 = allShows.Where(x => x.StartTime.Hours == 20).ToList();
            DisplayShows(showsAt20);
        }

        private static void CheckIfProgramExist(List<Show> allShows)
        {
            Console.WriteLine($"\nFINNS PROGRAMMET KULTURNYHETERNA?");
            string result = allShows.Any(x => x.Name == "Kulturnyheterna") ? "Ja" : "Nej";
            Console.WriteLine(result);

            Console.WriteLine($"\nFINNS PROGRAMMET \'ENSAM PAPPA SÖKER\'?");
            string result2 = allShows.Any(x => x.Name == "Ensam pappa söker") ? "Ja" : "Nej";
            Console.WriteLine(result2);
        }

        private static void DisplaySVT2Shows(List<Show> allShows)
        {
            Console.WriteLine("\nPROGRAM FRÅN SVT2 I KRONOLOGISK ORDNING");
            List<Show> showsSVT2 = allShows.Where(x => x.Channel == "SVT2").OrderBy(x => x.StartTime).ToList();
            DisplayShows(showsSVT2);
        }

        private static void DisplayShowsStartingLaterThan21(List<Show> allShows)
        {
            Console.WriteLine("\nPROGRAM SOM BÖRJAR SENARE ÄN 21");
            var startLaterThan21 = allShows.Where(x => x.StartTime.Hours >= 21).ToList();
            DisplayShows(startLaterThan21);

            //LINQ LÖSNING
            //var showsLaterThan21 = allShows.Where(x => x.StartTime.Hours >= 21);
            //showsLaterThan21.ToList().ForEach(x => Console.WriteLine(x.Name));
        }

        private static void DisplayAllTitles(List<Show> allShows)
        {
            Console.WriteLine("\nALLA TITLAR");
            DisplayShows(allShows);
        }

        private static void DisplayShows(List<Show> showList)
        {
            foreach (var show in showList)
            {
                Console.WriteLine(show.Name);
            }
        }

        //LINQ skriva ut element i lista tex namn
        //allShows.ForEach(x => Console.WriteLine(x.Name));
        //
    }
}
