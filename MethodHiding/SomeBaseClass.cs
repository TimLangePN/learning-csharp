using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class SomeBaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Method in base class");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Virtual method in base class");
        }

    }
}
