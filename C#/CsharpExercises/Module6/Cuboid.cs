using System;
using System.Collections.Generic;
using System.Text;

namespace Module6
{
    class Cuboid
    {
        //Properties
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public string Color { get; set; }

        //Constructors
        public Cuboid(int w, int h, int d)
        {
            Width = w;
            Height = h;
            Depth = d;
        }
        public Cuboid(string c)
        {
            Color = c;
        }

        //Methods
        public string ChangeColor(string c)
        {
            Color = c;
            return Color;
        }


        public void WriteVolume()
        {
            double volume = CalculateVolume();
            Console.WriteLine($"The volume of the cube is {volume}");
        }

        public double CalculateVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public double CalculateArea()
        {
            double area = (Width * Height * 2) + (Depth * Height * 2) + (Width * Depth * 2);
            return area;
        }
    }
}
