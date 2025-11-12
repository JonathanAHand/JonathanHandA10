namespace Assignment10.Model.Person
{
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        private string _major;
        private string _minor;

        public string Major
        {
            get => _major;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value), "Major cannot be null.");
                }

                _major = value == string.Empty ? Undeclared : value;
            }
        }

        public string Minor
        {
            get => _minor;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value), "Minor cannot be null.");
                }

                _minor = value == string.Empty ? Undeclared : value;
            }
        }

        public override string Details
        {
            get
            {
                string addressInfo = HomeAddress != null ? HomeAddress.ToString() : "No Address";
                return $"Name: {FirstName} {LastName}, ID: {Id}, Major: {Major}, Minor: {Minor}, Address: {addressInfo}";
            }
        }

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

        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major)
            : base(firstName, lastName, id, homeAddress)
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
