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
        private string rating;

        // Static attribute
        public static int bookCount = 0;

        // Constructor
        public Book(string aTitle, string aAuthor, int aPages, string aRating) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Rating = aRating;

            ++bookCount;
        }

        //Object method
        public bool IsThick()
        {
            if (pages >= 300) { return true; }
            else { return false; }
        }

        // Getters and setters for rating
        public string Rating
        {
            get { return rating; }
            
            set 
            {
                switch (value)
                {
                    case "G":
                    case "PG":
                    case "PG-13":
                    case "R":
                    case "NR":
                        rating = value;
                        break;
                    default: 
                        rating = "NR";
                        break;
                }
            }
        }
    }
}
