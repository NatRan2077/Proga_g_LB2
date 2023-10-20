using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Класс "Книга"
    class Book : PrintEdition
    {
        public string Author { get; set; }

        public override void ToString()
        {
            Console.WriteLine($"Book: {Title}, Year: {Year}, Author: {Author}");
        }
    }
}
