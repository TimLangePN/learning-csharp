using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopLessApp.Contracts
{
    public interface IInputHandler
    {
        void RecursiveWriter(string inputName, int counter);
    }
}
