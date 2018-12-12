using System;
using System.Collections.Generic;
using System.Text;

namespace _11._2_Customers
{
    public enum Gender
    {
        Female, Male, Other
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
    }
}
