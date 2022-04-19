using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @""; //path
            string[] lines = { "Hello 1", "Hello 2", "Hello 3" };

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path))
            {
                foreach(var line in lines)
                {
                    writer.WriteLine(line);
                }
            }

        }
    }
}