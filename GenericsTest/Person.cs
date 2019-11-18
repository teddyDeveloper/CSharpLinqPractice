using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public abstract class Person
    {
        public int Age { get; set; } = 21;
        public abstract void PrintName();
    }
}
