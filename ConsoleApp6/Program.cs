using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEdition[] printEditions = {
            new Journal { Title = "National Geographic", Year = 2021, IssueNumber = 10 },
            new Book { Title = "Harry Potter and the Sorcerer's Stone", Year = 1997, Author = "J.K. Rowling" },
            new Textbook { Title = "Introduction to Machine Learning", Year = 2022, Subject = "Computer Science" },
            new Journal { Title = "Vogue", Year = 2021, IssueNumber = 5 }
        };

            Person[] people = {
            new Author { Name = "Jane Austen", YearOfBirth = 1775 },
            new Author { Name = "Mark Twain", YearOfBirth = 1835 },
            new Author { Name = "Agatha Christie", YearOfBirth = 1890 }
        };

            Publisher publisher = new Publisher { Name = "Penguin Books" };

            foreach (PrintEdition printEdition in printEditions)
            {
                printEdition.ToString();
            }

            foreach (Person person in people)
            {
                person.ToString();
            }

            publisher.ToString();
        }
    }

}
