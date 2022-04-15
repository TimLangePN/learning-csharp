using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNonStatic
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string argFirstname, string argLastname)
        {
            Firstname = argFirstname;
            Lastname = argLastname;
        }

        //Non static
        public string FormatFullname()
        {
            return $"{Firstname} - {Lastname}";
        }


        //Static
        /*        public static string FormatFullname(string argFirstname, string argLastname)
                {
                    return $"{argFirstname} - {argLastname}";
                }*/
    }
}