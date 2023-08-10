using _04_classes;
using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Test Title", "Test Author", 120);
            Book book2 = new Book("Test Title2", "Test Author2", 560);

            Console.WriteLine(book1.title);

            Console.WriteLine("Is Book 1 thick? " + book1.IsThick());
            Console.WriteLine("Is Book 2 thick? " + book2.IsThick());

            Console.ReadLine();
        }
    }
}
