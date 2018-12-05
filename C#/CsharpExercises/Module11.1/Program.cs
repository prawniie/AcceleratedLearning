using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11._1
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> numberGT5 = NumbersHigherThanFive();
            //List<string> starsList = StarifyList(numberGT5);
            List<string> starsList = StarifyListLINQ(numberGT5);

            Console.WriteLine($"Starslist = {string.Join(",", starsList)}");


            //var listOfNumbers = new List<int> { 3, 5, 10, 11 };

            //List<int> numberHigherThanFive = NumberHigherThanFive(listOfNumbers);

            //DisplayNumbers(numberHigherThanFive);

            //var list = new List<double> { 5, 10, 4 };
            ////Medelvärde med LINQ
            //Console.WriteLine($"The average is {list.Average()}");

            ////Medelvärde utan LINQ
            //double average = Average(list);
            //Console.WriteLine($"The average is {average}");

            ////Summering med LINQ
            //Console.WriteLine($"The sum is {list.Sum()}");

            ////Summering utan LINQ
            //double sum = SumOfNumbers(list);
            //Console.WriteLine($"The sum is {sum}");

        }

        //MED LINQ
        private static List<string> StarifyListLINQ(List<int> numberGT5)
        {
            List<string> starsList = numberGT5.Select(x => "***" + x + "***").ToList();

            return starsList;


        }

        //UTAN LINQ
        private static List<string> StarifyList(List<int> numberGT5)
        {
            List<string> numsStarified = new List<string>();

            foreach (var item in numberGT5)
            {
                numsStarified.Add($"*{item}*");
            }

            return numsStarified;

        }

        private static List<int> NumbersHigherThanFive()
        {
            //Använder LINQ för att skapa en List<int> med siffror som är högre än 5 från en lista
            int[] newNums = { 1, 2, 3, 7, 10, 35, 80, 100 };
            List<int> numberGT5 = newNums.Where(x => x > 5).ToList();
            //Console.WriteLine(string.Join(",", numberGT5));

            return numberGT5;
        }

        private static List<int> NumberHigherThanFive(List<int> listOfNumbers)
        {
            var numberHigherThanFive = new List<int>();

            //UTAN LINQ
            foreach (int number in listOfNumbers)
            {
                if (number > 5)
                {
                    numberHigherThanFive.Add(number);
                }
            }

            //MED LINQ

            //foreach (int number in listOfNumbers.Where(number => number>5))
            //{
            //    numberHigherThanFive.Add(number);
            //}
            
            return numberHigherThanFive;
            
        }

        private static void DisplayNumbers(List<int> numberHigherThanFive)
        {
            Console.WriteLine($"There are {numberHigherThanFive.Count} numbers higher than five: ");
            foreach (int number in numberHigherThanFive)
            {
                Console.WriteLine($"{number}");
            }
        }

        private static double SumOfNumbers(List<double> list)
        {
            double sum = 0;

            foreach (double number in list)
            {
                sum += number;
            }

            return sum;
        }

        private static double Average(List<double> list)
        {
            //double sum = 0;

            //foreach (double number in list)
            //{
            //    sum += number;
            //}

            return (SumOfNumbers(list) / list.Count);
        }
    }
}
