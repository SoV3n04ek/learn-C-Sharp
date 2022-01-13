namespace Program {
    class Reader
    {
        private string name { get; set; }
        private string lastName { get; set; }

        private int count;

        private Book[] books;

        public Reader(string _name, string _lastName, Book[] _books)
        {
            name = _name;
            lastName = _lastName;
            books = _books;
            count = _books.Length;
        }

        public void Add(Book book)
        {
           Book[] tmpbooks = new Book[books.Length + 1];

            for (int i = 0; i < books.Length; i++)
            {
                tmpbooks[i] = books[i];
            }

            tmpbooks[tmpbooks.Length - 1] = book;
            books = tmpbooks;
        }

        public void Delete(Book book)
        {
            Book[] tmpbooks = new Book[books.Length - 1];

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == book)
                {
                    continue;
                }
                tmpbooks[i] = books[i];
            }

            books = tmpbooks;
        }

        Book[] GetBooks()
        {
            return books;
        }

        public override string ToString()
        {
            
            string str = "";


            if (books.Length > 0)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    str += $"\nBook #{i + 1}:\n" + books[i].ToString();
                }
            }
            else if (books.Length == 0)
            {
                str = "\nBooks: Haven't\n";
            }

            return "Name: " + name + ",\n" +
                "Lastname: " + lastName + ",\n" + str;
        }
    }
}