namespace Assignment10.Model.Person
{
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        public string Major { get; set; }

        public string Minor { get; set; }

        private Student()
        {

        }

        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Major - {Major}";
        }
    }
}
