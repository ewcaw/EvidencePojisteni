using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokusEvidence
{
    class Pojistenec
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public Pojistenec (string firstName, string lastName, string phone, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Age = age;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Phone + " " + Age;
        }

    }
}
