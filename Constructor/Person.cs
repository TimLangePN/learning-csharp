using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Person
    {
        private string _firstname;
        private string _lastname;
        private int _age = 10;

        public Person()
        {
            _firstname = "T";
            _lastname = "L";
        }

        public Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        public Person(string firstname, int age)
        {
            _firstname = firstname;
            _lastname = "Mulder";
            _age = age;
        }

        public Person(string firstname, string lastname, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }

        public string GetFullNameWithAge() 
        {
            return $"{_firstname} {_lastname} {_age}";
        }
        public string GetFullNameWithAge(int age)
        {
            return $"{_firstname} {_lastname} {age}";
        }
    }
}
