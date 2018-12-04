using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Module10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> products = BuildProductDictionary();
            DisplayProductDictionary(products);

        }


        private static Dictionary<int, string> BuildProductDictionary()
        {
            Dictionary<int, string> products = new Dictionary<int, string>();

            while (true)
            {
            Console.Write("Enter product id and name: ");
            string input = Console.ReadLine();

                if (ValidInput(input) || string.IsNullOrWhiteSpace(input))
                {
                 input = input.Trim();   
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input!");
                    Console.ResetColor();
                    continue;
                }
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    return products;
                }

            string[] idAndName = input.Split(',');
            int key = int.Parse(idAndName[0]);
            string productName = idAndName[1];

                if (products.ContainsKey(key))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is already a product with this key!");
                    Console.ResetColor();
                }
                else
                {
                    products.Add(key, productName);
                }
            }
            

        }

        private static bool ValidInput(string input)
        {
            //Det är något knasigt med min Regex kod.."
            string pattern = @"^\d+,\s?[a-zA-Z]+$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Product id = {item.Key} and name = {item.Value}");
            }

            Console.WriteLine();
        }
    }
}
