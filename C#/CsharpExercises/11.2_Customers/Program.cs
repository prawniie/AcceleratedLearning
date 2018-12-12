using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11._2_Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = CreateListOfCustomers("PersonShort.txt");
            SortCustomerByAge(list);
            SortCustomerByFirstName(list);
            MenOlderThan35(list);
            ManipulatedList(list);

            Console.WriteLine();

            ////OSCARS LÖSNINGAR
            //list.Sort((c1,c2) => c1.Age - c2.Age);
            //list.Sort((c1, c2) => string.Compare(c1.FirstName, c2.LastName));
            //KOLLA LÖSNING PÅ MANIPULATEDLIST VARIANTEN
        }

        private static void ManipulatedList(List<Customer> list)
        {
            Console.WriteLine("\nManipulated:");

            foreach (var item in list)
            {
                item.FirstName = item.FirstName.ToUpper();
                item.Age = item.Age + 100;
                PrintCustomerInfo(item);
            }
        }

        private static void MenOlderThan35(List<Customer> list)
        {
            Console.WriteLine("\nMen older than 35:");
            var menOlderThan35 = list.Where(customer => customer.Age > 35).ToList();

            foreach (var item in menOlderThan35)
            {
                PrintCustomerInfo(item);
            }
        }

        private static void SortCustomerByFirstName(List<Customer> list)
        {
            Console.WriteLine("\nSorted list by first name: ");
            var sortedByFirstName = list.OrderBy(customer => customer.FirstName).ToList();

            foreach (var item in sortedByFirstName)
            {
                PrintCustomerInfo(item);
            }
        }

        private static void SortCustomerByAge(List<Customer> list)
        {
            Console.WriteLine("Sorted list by age:");
            var sortedByAge = list.OrderBy(customer => customer.Age).ToList();
            foreach (var item in sortedByAge)
            {
                PrintCustomerInfo(item);
            }
        }

        private static void PrintCustomerInfo(Customer item)
        {
            Console.WriteLine($"{item.FirstName.PadRight(20)}{item.Age.ToString().PadRight(20)}{item.Gender}");
        }

        private static List<Customer> CreateListOfCustomers(string textFile)
        {
            string[] allLines = File.ReadAllLines(textFile);

            List<Customer> customerInfo = new List<Customer>();

            foreach (var line in allLines)
            {
                string[] customerLine = line.Split(',');
                Customer customer = new Customer();
                customer.Id = int.Parse(customerLine[0]);
                customer.FirstName = customerLine[1];
                customer.LastName = customerLine[2];
                customer.Email = customerLine[3];
                customer.Gender = (Gender)Enum.Parse(typeof(Gender), customerLine[4]);
                customer.Age = int.Parse(customerLine[5]);
                customerInfo.Add(customer);

            }

            return customerInfo;
        }
    }
}
