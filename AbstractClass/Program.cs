﻿using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tim = new Tim("Tim", "Lange");
            Console.WriteLine(tim.GetFullName());

            tim.Greet();
        }
    }
}
