using System;
using Program;

namespace ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("name", "surname", 1984);
            Book a = new Book(1, "Name", author, "Description", 17849102);

            int count = 10;
            Book[] books = new Book[count];

            Reader reader = new Reader("name", "surname", count, books);

            Console.WriteLine(author.ToString());
        }
    }
}