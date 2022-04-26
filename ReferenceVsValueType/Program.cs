using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVsValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Tim";
            person1.LastName = "Lange";

            ChangeFirstName(person1);

            Console.Write(person1.FirstName);
            Console.Write(person1.LastName);
        }

        static void ChangeFirstName(Person person)
        {
            person.FirstName = "Vincent";
        }
    }
}