namespace Program
{
    class Author
    {
        private string name { get; set; }
        private string lastName { get; set; }
        private int birthdayYear { get; set; }

        public Author(string _name, string _lastName, int _birthdayYear)
        {
            name         = _name;
            lastName     = _lastName;
            birthdayYear = _birthdayYear;
        }
        public override string ToString()
        {
            return "Name: " + name + "," +
                " Last Name: " + lastName + ", " +
                "birthday year: " + birthdayYear.ToString();
        }
    }

    class Reader 
    {
        private string name { get; set; }
        private string lastName { get; set; }

        private int count;

        private Book[] books;

        public Reader(string _name, string _lastName, int countBooks, Book[] _books) 
        {
            name     = _name;
            lastName = _lastName;
            books    = _books;  
            count    = countBooks;
        }

        public void Add(Book book)
        {
            Book[] tmpbooks = new Book[count + 1];

            for (int i = 0; i < books.Length; i++)
            {
                tmpbooks[i] = books[i];
            }

            tmpbooks[tmpbooks.Length] = book;
            count++;
        }

        public void Delete(Book book)
        {
            Book[] tmpbooks = new Book [count - 1];

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == book)
                {
                    continue;
                }
                tmpbooks[i] = books[i];
            }

            books = tmpbooks;
            count--;
        }

        Book[] GetBooks()
        {
            return books;
        }

        public override string ToString()
        {
            string arr = "";

            for (int i = 0; i < count; i++)
            {
                arr += books[i].ToString();
            }

            return "Name: "  + name + ",\n" + 
                "Lastname: " + lastName + ",\n" + arr;
        }
    }

    class Book
    {
        private int id { get; set; }
        private string name { get; set; }
        private Author author { get; set; }
        private string description { get; set; }
        private int ISBN { get; set; }

        public Book(int _id, string _name, Author _author, string _description, int _ISBN)
        {
            id          = _id;
            name        = _name;
            author      = _author;
            description = _description;
            ISBN        = _ISBN;
        }

        public Book(Book other)
        {
            id          = other.id;
            name        = other.name;
            author      = other.author;
            description = other.description;
            ISBN        = other.ISBN;
        }
        public override string ToString()
        {
            return "Id: " + id.ToString() + ",\n" +
                "Name: " + name + ",\n" +
                "Author: \n" + author.ToString() + ",\n" +
                "Description: " + description + ",\n" +
                "ISBN: " + ISBN.ToString() + "\n";
        }
    }
}  