using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Класс "Издательство"
    class Publisher
    {
        public string Name { get; set; }

        public void ToString()
        {
            Console.WriteLine($"Publisher: {Name}");
        }
    }

}
