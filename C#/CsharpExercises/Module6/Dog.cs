using System;
using System.Collections.Generic;
using System.Text;

namespace Module6
{
    class Dog
    {
        //Properties
        public int Age { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string FavoriteFood { get; set; }


        //Constructors
        public Dog(string n, int a)
        {
            Name = n;
            Age = a;

        }

        public Dog()
        {

        }

        //Methods

        public void ChangeBreed(string x)
        {
            Breed = x;
        }
    }
}
