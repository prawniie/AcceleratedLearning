using System;

namespace Module6._6
{
    class Program
    {
        static void Main(string[] args)
        {


            //DrawSquare(10, 20);
            //Console.WriteLine();
            //DrawSquare(5, 50);
            //Console.WriteLine();
            //DrawSquare(3, 6);
            //Console.WriteLine();

            MultiplicationTable(2);

        }

        private static void MultiplicationTable(int x)
        {

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Multiplication table for {i}");
                Console.WriteLine();

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i,j,i*j);
                }
                Console.WriteLine();
            }

        }

        private static void DrawSquare(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("".PadLeft(y));

                for (int j = 0; j < x; j++)
                {

                    Console.Write("o");
                }

                Console.WriteLine("o");



            }

        }
    }
}
