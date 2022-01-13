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
    }
}  