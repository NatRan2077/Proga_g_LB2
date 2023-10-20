using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Класс "Журнал"
    class Journal : PrintEdition
    {
        public int IssueNumber { get; set; }

        public override void ToString()
        {
            Console.WriteLine($"Journal: {Title}, Year: {Year}, Issue Number: {IssueNumber}");
        }
    }
}
