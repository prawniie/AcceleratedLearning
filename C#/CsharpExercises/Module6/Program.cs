using System;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            SportStuff();
            //CoffeMachineStuff();
            //DogStuff();
            //CuboidStuff();
            //CircleStuff();
        }

        private static void SportStuff()
        {
            Person Lisa = new Person
            {
                FirstName = "Lisa",
                LastName = "Jacobsson",
                BirthDay = new DateTime(1990, 6, 11),
                Gender = Gender.Female,
                FavoriteSport = Sport.Soccer
            };

            //Print info about Lisa
            Console.WriteLine($"Lisa is {Lisa.Gender.ToString().ToLower()}.");
            Console.WriteLine($"Lisa likes to play {Lisa.FavoriteSport.ToString().ToLower()}.");

            if (Lisa.FavoriteSport == Sport.Rugby)
            {
                Console.WriteLine("Lisa likes rugby.");
            }
            else
                Console.WriteLine("Lisa doesn't like rugby.");

            //Print sports
            Console.WriteLine("\nHere is a list of all sport enums: \n");

            foreach (string sportName in Enum.GetNames(typeof(Sport)))
            {
                Console.WriteLine($"* {sportName}");
            }

            //Ask for sport
            Console.Write("\nEnter a sport: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string maybeSport = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (Enum.TryParse(maybeSport, true, out Sport sport))
            {
                Console.WriteLine($"Oh, I know {sport}!");
            }
            else
            {
                Console.WriteLine($"I don't know the sport {maybeSport}");
            }

            //KOLLA OSCARS KOD FÖR OM SPORTEN INGÅR I SPORTS

            Console.WriteLine();
        }

        private static void CoffeMachineStuff()
        {
            CoffeMachine coffeMachine1 = new CoffeMachine();
            coffeMachine1.Color = CoffeMachineColor.Red;
        }

        private static void DogStuff()
        {
            Dog dog1 = new Dog("Erke", 1);
            dog1.Breed = "Finsk lapphund";
            Console.WriteLine($"{dog1.Name} is a {dog1.Breed}.");

            dog1.ChangeBreed("Boxer");
            Console.WriteLine($"{dog1.Name} is a {dog1.Breed}.");

        }

        private static void CuboidStuff()
        {
            Cuboid myCube = new Cuboid(2,3,4);
            myCube.Color = "Yellow";

            Console.WriteLine(myCube.Color);

            Cuboid mySuperCube = new Cuboid(100, 200, 300);
            mySuperCube.Color = "Blue";

            //double volume = myCube.CalculateVolume();
            //Console.WriteLine($"Volume: {volume}");

            //double superVolume = mySuperCube.CalculateVolume();
            //Console.WriteLine($"Volume: {superVolume}");

            //myCube.WriteColor();
            //mySuperCube.WriteColor();

            double area = myCube.CalculateArea();
            Console.WriteLine($"The area of the cuboid is {area}.");

            double superArea = mySuperCube.CalculateArea();
            Console.WriteLine($"The area of the cuboid is {superArea}.");

            string color = myCube.ChangeColor("Red");
            Console.WriteLine($"The color of the cube is {myCube.Color}.");


            Console.WriteLine();

        }

        private static void CircleStuff()
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);
            Circle zelda = new Circle();
            Circle midna = new Circle("Midna");

            bob.SayHello();
            lisa.SayHello();
            zelda.SayHello();
            midna.SayHello();

            Console.WriteLine();

            bob.WriteArea();
            lisa.WriteArea();
            zelda.WriteArea();
            midna.WriteArea();

            Console.WriteLine();

        }
    }


    class Car
    {
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string c, int w)
        {
            Color = c;
            Weight = w;
        }

        public Car()
        {

        }

    }
}
