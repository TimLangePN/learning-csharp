using LoopLessApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopLessApp.Service
{
    public class InputHandler : IInputHandler
    {
        public void RecursiveWriter(string inputName, int counter)
        {
            if (counter > 0)
            {
                Console.WriteLine(inputName);
                counter--;
                RecursiveWriter(inputName, counter);
            }
        }
    }
}
