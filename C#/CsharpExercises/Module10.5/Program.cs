using System;
using System.Collections.Generic;

namespace Module10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> products = BuildProductDictionary();
            DisplayProductDictionary(products);

            //Har ej lagt till om produktlistan innehåller samma ID 

            //Console.WriteLine($"{priceCategories['A']}");

            //if (priceCategories.ContainsKey('B'))
            //{
            //    Console.WriteLine("Det finns en kategori som heter B");
            //}
        }


        private static Dictionary<int, string> BuildProductDictionary()
        {
            Dictionary<int, string> products = new Dictionary<int, string>();

            while (true)
            {
            Console.Write("Enter product id and name: ");
            string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

            string[] idAndName = input.Split(',');
            int key = int.Parse(idAndName[0]);
            products.Add(key, idAndName[1]);
            }
            return products;

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
