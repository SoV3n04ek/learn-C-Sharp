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
        
        public static bool operator ==(Author b1, Author b2)
        {
            if (b1 is null)
                return b2 is null;

            return b1.Equals(b2);
        }

        public static bool operator !=(Author b1, Author b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return obj is Author b2 ? (name == b2.name &&
                                   lastName == b2.lastName &&
                                   birthdayYear == b2.birthdayYear) : false;

        }

        public override int GetHashCode()
        {
            return (name, lastName, birthdayYear).GetHashCode();
        }
    }
}
