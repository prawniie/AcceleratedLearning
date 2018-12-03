using System;
using System.IO;

namespace Module8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChocholateStuff();
            CreateFileStuff();
            //WriteToFileStuff();
        }

        private static void WriteToFileStuff()
        {
            //string text = "Erika är en go och gla tjej";

            //File.WriteAllText(@"C:\Project\Erikaärbäst.txt", text);

            string text2 = File.ReadAllText(@"C:\Project\Snartärdetslutföridag.txt");

            Console.WriteLine(text2);

        //C:\Project\Erikaärbäst.txt
        }

        private static void CreateFileStuff()
        {
            Console.Write("Enter a file name: ");
            string fileName = Console.ReadLine();

            try
            {
                File.CreateText(fileName);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The file {fileName} is now created.");
                Console.ResetColor();
            }

            catch(UnauthorizedAccessException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You're not authorized to create this file!.");
                Console.WriteLine(ex.Message);
            }

            catch(ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter a file path!");
                Console.WriteLine(ex.Message);
            }

            catch(DirectoryNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Couldn't find the file path!");
                Console.WriteLine(ex.Message);
            }

            catch(IOException ex)
            {
                Console.WriteLine("Name of file path in incorrect format!");
                Console.WriteLine(ex.Message);
            }


            catch (Exception ex)
            {
                Console.WriteLine("Something wrong happened..");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

   
        }

        private static void ChocholateStuff()
        {
            Console.WriteLine("The chocolate contains 24 pieces");
            Console.Write("How many want to share? ");

            try
            {

                decimal number = decimal.Parse(Console.ReadLine());
                decimal pieces = CalculatePieces(number);

                Console.WriteLine($"Everyone get {pieces:.##} pieces");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to enter a number!");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero people can't divide a chocolate!");
                Console.WriteLine(e.Message);

            }

            Console.WriteLine();
            Console.ResetColor();

        }

        private static decimal CalculatePieces(decimal number)
        {
            if (number < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("You cannot enter a negative number!");
            }

            return 24 / number;
        }
    }
}
