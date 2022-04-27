using System;

namespace RefParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool a = true; -> ref param

            bool a; //out param

            makeItFalse(out a);

            Console.WriteLine(a);
        }

        static void makeItFalse(out bool a)
        {
            a = false;
        }
    }
}
