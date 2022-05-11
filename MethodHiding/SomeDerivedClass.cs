using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class SomeDerivedClass : SomeBaseClass
    {
        public new void Method1()
        {
            Console.WriteLine("Method in derived class");
        }

        public override void Method2()
        {
            Console.WriteLine("Override method in derived class");
        }
    }
}
