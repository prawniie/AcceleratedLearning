using System;
using System.Collections.Generic;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = AskUserForInput();
            PrintShapes(shapes);
            Summarize(shapes);
        }

        private static List<Shape> AskUserForInput()
        {
            List<Shape> shapes = new List<Shape>();
            string input;

            do
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                input = Console.ReadLine();

                if (input == "T")
                {
                    AskForTriangle(shapes);
                }
                else if (input == "R")
                {
                    AskForRectangle(shapes);
                }
                else if (input == "C")
                {
                    AskForCircle(shapes);
                }

            } while (input != "D");

            return shapes;
        }

        private static void AskForCircle(List<Shape> shapes)
        {
            var x = new Circle();
            shapes.Add(x);
            Console.WriteLine("Enter radius of circle: ");
            x.Radius = int.Parse(Console.ReadLine());
        }

        private static void AskForRectangle(List<Shape> shapes)
        {
            var x = new Rectangle();
            shapes.Add(x);
            Console.WriteLine("Enter height of rectangle: ");
            x.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle: ");
            x.Width = int.Parse(Console.ReadLine());
        }

        private static void AskForTriangle(List<Shape> shapes)
        {
            var x = new Triangle();
            shapes.Add(x);
            Console.WriteLine("Enter height of triangle: ");
            x.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of triangle: ");
            x.Width = int.Parse(Console.ReadLine());
        }

        private static void PrintShapes(List<Shape> shapes)
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Shape item in shapes)
            {

                if (item is Circle)
                {
                    Console.WriteLine($"I am a circle and my radius is {item.Radius}");
                }
                else
                    Console.WriteLine($"I am a {item.Name} and my width is {item.Width} and my height is {item.Height}.");
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        private static void Summarize(List<Shape> shapes)
        {
            Console.WriteLine($"\nNumber of shapes selected: {shapes.Count}.\n");
        }

        /*
        //if (a is Cat)
        {
            bara cat.SayHello(); går inte 
            var cat = (Cat)a;
            cat.SayHello();
        }
        */

    }
}
