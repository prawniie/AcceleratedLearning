using System;
using System.Collections.Generic;
using System.Text;

namespace Module6
{

    enum Sport
    {
        Tennis, Rugby, Soccer, Hurling, Squash
    }

    enum Gender
    {
        Male, Female, Other
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public Sport FavoriteSport { get; set; }
    }
}
