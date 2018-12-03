using System;

namespace Module_6._5
{
    class Program
    {
        static void Main(string[] args)
        {

            Address street1 = new Address
            {
                Street = "Björnbärsvägen",
                StreetNumber = 14,
                City = "Borås",
                ZipCode = 51350
            };

            street1.SetZipCode("435 00");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Street".PadRight(20) + street1.Street);
            Console.WriteLine($"StreetNumber".PadRight(20) + street1.StreetNumber);
            Console.WriteLine($"City".PadRight(20) + street1.City);
            Console.WriteLine($"ZipCode".PadRight(20) + street1.ZipCode);
            Console.WriteLine($"FullStreet".PadRight(20) + street1.FullStreet);

            Console.WriteLine();
            Console.ResetColor();

        }
    }
}
