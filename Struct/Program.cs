using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); //value type instead of reference type
            person.Firstname = "Tim";
            person.Lastname = "Lange";

            ChangeFullName(person);

            Console.WriteLine(person.Firstname);
            Console.WriteLine(person.Lastname);
        }

        static void ChangeFullName(Person person)
        {
            person.Firstname = "Vincent";
            person.Lastname = "Ros";
        }
    }
}
