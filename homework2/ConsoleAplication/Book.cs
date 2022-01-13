namespace Program
{
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

        public static bool operator ==(Book b1, Book b2)
        {
            if (b1 is null)
                return b2 is null;

            return b1.Equals(b2);
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return obj is Book b2 ? (id == b2.id &&
                                   name == b2.name &&
                                   description == b2.description) : false;

        }

        public override int GetHashCode()
        {
            return (id, name, description).GetHashCode();
        }
    }
}  