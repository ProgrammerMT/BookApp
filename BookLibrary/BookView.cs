using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal class BookView
    {
        public void DisplayBooks(List<Book> books)
        {
            Console.WriteLine("\nСписък с книги:");
            if (books.Count == 0)
            {
                Console.WriteLine("Няма налични книги.");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"- {book.Title} от {book.Author} ({book.YearPublished})");
                }
            }
        }

        public Book GetNewBookDetails()
        {
            Console.WriteLine("\nДобавяне на нова книга:");
            Console.Write("Заглавие: ");
            string title = Console.ReadLine();

            Console.Write("Автор: ");
            string author = Console.ReadLine();

            Console.Write("Година на издаване: ");
            int yearPublished;
            while (!int.TryParse(Console.ReadLine(), out yearPublished) || yearPublished < 0)
            {
                Console.Write("Моля, въведете валидна година: ");
            }

            return new Book(title, author, yearPublished);
        }
    }
}
