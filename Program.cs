using _04_classes;
using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book();

            book1.title = "Test Title";
            book1.author = "Test Author";
            book1.pages = 345;

            Console.WriteLine(book1.title);

            Console.ReadLine();
        }
    }
}
