﻿using System;
using Program;

namespace ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("name", "surname", 1984);
            Book a = new Book(1, "Name", author, "Description", 17849102);

            Book[] books = {
              //  new Book(1, "Name", author, "Description", 17849102),
            };

            Reader reader = new Reader("name", "surname", books);

            reader.Add(new Book(1, "Name", author, "Description", 17849102));
            author.name = "Alexey";
            reader.Add(new Book(2, "Name2", author, "Description ", 17849101));

            Console.WriteLine(reader.ToString());
        }
    }
}