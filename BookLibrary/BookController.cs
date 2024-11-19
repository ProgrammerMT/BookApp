using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal class BookController
    {
        private List<Book> books = new List<Book>();
        private BookView view = new BookView();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Показване на списъка с книги");
                Console.WriteLine("2. Добавяне на нова книга");
                Console.WriteLine("3. Изход");
                Console.Write("Изберете опция: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        view.DisplayBooks(books);
                        break;

                    case "2":
                        Book newBook = view.GetNewBookDetails();
                        books.Add(newBook);
                        Console.WriteLine("Книгата е добавена успешно!");
                        break;

                    case "3":
                        running = false;
                        Console.WriteLine("Изход от програмата. Довиждане!");
                        break;

                    default:
                        Console.WriteLine("Невалидна опция. Опитайте отново.");
                        break;
                }
            }
        }
    }
}
