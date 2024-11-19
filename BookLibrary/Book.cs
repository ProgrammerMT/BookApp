using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public Book(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
    }
}
