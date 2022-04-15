using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopLessApp
{
    public class InputHandler
    {
        public string InputName { get; set; }
        public int Counter { get; set; }

        public void RecursiveWriter(string InputName, int Counter)
        {
            if(Counter > 0)
            {
                Console.WriteLine(InputName);
                Counter--;
                RecursiveWriter(InputName, Counter);
            }
        }
    }
}