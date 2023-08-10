using _04_classes;
using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            // G, PG, PG-13, R, NR

            Book book1 = new Book("Test Title", "Test Author", 120, "PG");
            Console.WriteLine("Books created: " + Book.bookCount);
            Book book2 = new Book("Test Title2", "Test Author2", 560, "R");
            Console.WriteLine("Books created: " + Book.bookCount);

            Console.WriteLine(book1.title);

            Console.WriteLine("Is Book 1 thick? " + book1.IsThick());
            Console.WriteLine("Is Book 2 thick? " + book2.IsThick());

            book1.Rating = "G";

            Console.WriteLine("Book 1 rating is: " + book1.Rating);
            Console.WriteLine("Book 2 rating is: " + book2.Rating);

            // Static attribute can be accessed by the class name
            Console.WriteLine("Books created: " + Book.bookCount);
            Console.WriteLine("Books created: " + book1.GetBookCount());

            Console.ReadLine();
        }
    }
}
