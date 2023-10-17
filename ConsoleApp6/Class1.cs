using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    // Базовый класс - Печатное издание
    public  class PrintedPublication
    {
        public string Title { get; set; } // Название издания
        public int Year { get; set; } // Год издания
    }

    // Класс Книга, наследуется от Печатного издания
    public class Book : PrintedPublication
    {
        public Author Author { get; set; } // Автор книги
        public PublishingHouse Publisher { get; set; } // Издательство
    }

    // Класс Учебник, наследуется от Книги
    //бесплодный класс
    public sealed class Textbook : Book
    {
        public string Subject { get; set; } // Предмет

        public override string ToString()
        {
            return $"Subject: {Subject}";
        }
    }

    // Класс Журнал, наследуется от Печатного издания
    public class Magazine : PrintedPublication
    {
        public int Issue { get; set; } // Номер журнала\

        public int Frequency { get; set; } // Частота выпусков журнала

        public override string ToString()
        {
            return $"Issue: {Issue},Frequency {Frequency} ";
        }
    }


    // Класс Персона, представляющий информацию о человеке
    public  class  Person       
    {
        public string Name { get; set; } // Имя человека
    }



    // Класс Автор, наследуется от Персоны
    // абстрактный класс 
    public abstract class  Author : Person
    {
        public abstract string Nationality { get; set; } // Национальность автора


    }
    public class PublishingHouse
    {
        public string Name { get; set; } // Название издательства
        public string Location { get; set; } // Местоположение издательства

        public override string ToString()
        {
            return $"Publishing House: {Name}, Location: {Location}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            PublishingHouse other = (PublishingHouse)obj;
            return Name == other.Name && Location == other.Location;
        }
    }

}
