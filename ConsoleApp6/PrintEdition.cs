using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class PrintEdition
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public abstract void ToString();
    }
}
