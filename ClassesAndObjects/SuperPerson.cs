using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class SuperPerson : Person   //Class inheritance
    {
        public void Fly() 
        {
            Console.WriteLine($"{FirstName}{LastName} Is flying!");
        }
    }
}
