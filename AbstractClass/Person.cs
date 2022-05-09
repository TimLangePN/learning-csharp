using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Person
    {
        private readonly string _firstname; //fields
        private readonly string _lastname;

        protected Person(string firstname, string lastname) //encapsulation
        {
            _firstname = firstname; //constructor
            _lastname = lastname;
        }
        public string GetFullName() //public method
        {
            return $"{_firstname} {_lastname}";
        }

    }
}
