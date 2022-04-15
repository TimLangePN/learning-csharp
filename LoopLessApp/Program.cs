using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopLessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler inputHandler = new();

            Console.WriteLine("Fill in name please");
            string inputName = Console.ReadLine();

            Console.WriteLine("Fill in a number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            inputHandler.RecursiveWriter(inputName, inputNumber);
        }
    }
}