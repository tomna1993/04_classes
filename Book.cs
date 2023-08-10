using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_classes
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        // Constructor
        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        //Object method
        public bool IsThick()
        {
            if (pages >= 300) { return true; }
            else { return false; }
        }
    }
}
