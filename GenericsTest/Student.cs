using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class Student : Person
    {
        public string Name { get; set; }

        public override void PrintName()
        {
            Console.WriteLine($"Student name is {Name} and is {Age} old.");
        }
    }
}
