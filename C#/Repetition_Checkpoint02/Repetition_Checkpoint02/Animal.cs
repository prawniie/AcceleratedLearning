using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition_Checkpoint02
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        //Konstruktorer
        public Animal(string n, int x)
        {
            Name = n;
            Age = x;
        }

        public Animal(string n)
        {
            Name = n;
            Age = 4;
        }

        public Animal()
        {

        }

    }
}
