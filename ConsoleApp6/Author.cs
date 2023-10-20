using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Author : Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public override void ToString()
        {
            Console.WriteLine($"Author: {Name}, Year of Birth: {YearOfBirth}");
        }
    }
}
