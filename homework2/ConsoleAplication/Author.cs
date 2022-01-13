namespace Program
{    class Author
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int birthdayYear { get; set; }

        public Author(string _name, string _lastName, int _birthdayYear)
        {
            name = _name;
            lastName = _lastName;
            birthdayYear = _birthdayYear;
        }

        public override string ToString()
        {
            return "Name: " + name + "," +
                " Last Name: " + lastName + ", " +
                "birthday year: " + birthdayYear.ToString();
        }
    }
}
