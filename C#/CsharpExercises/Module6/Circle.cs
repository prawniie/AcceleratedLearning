using System;
using System.Collections.Generic;
using System.Text;

namespace Module6
{
    class Circle
    {
            // Properties
            public int Radius { get; set; }
            public string Name { get; set; }

            // Constructors
            public Circle(string n, int r)
            {
                Name = n;
                Radius = r;
            }

            public Circle(string n)
            {
                Name = n;
                Radius = 5;
            }

            public Circle()
            {
                Name = "Unknown";
                Radius = 5;
            }

            // Methods
            public void SayHello()
            {
                Console.WriteLine($"I'm a circle with the name {Name}!");
            }

            public void WriteArea()
            {
                double area = Radius * Radius * Math.PI;
                Console.WriteLine($"My name is {Name}. I have a radius of {Radius} and an area of {area:##}.");
            }
    }
}
