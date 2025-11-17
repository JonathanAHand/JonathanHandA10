using System;

namespace Assignment10.Model.Person
{
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        private string _major;
        private string _minor;

        public string Major
        {
            get { return _major; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Major cannot be null.");
                }

                if (value == string.Empty)
                {
                    _major = Undeclared;
                }
                else
                {
                    _major = value;
                }
            }
        }

        public string Minor
        {
            get { return _minor; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Minor cannot be null.");
                }

                if (value == string.Empty)
                {
                    _minor = Undeclared;
                }
                else
                {
                    _minor = value;
                }
            }
        }

        public override string Details
        {
            get
            {
                string addressInfo = HomeAddress != null
                    ? HomeAddress.ToString()
                    : "No Home Address";

                string minorText = Minor == Undeclared ? "" : $", Minor: {Minor}";

                return $"{FirstName} {LastName} ({Id}){Environment.NewLine}" +
                       $"{addressInfo}{Environment.NewLine}" +
                       $"Major: {Major}{minorText}";
            }
        }

        

        private Student()
        {
        }

        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id)
            : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress)
            : this(firstName, lastName, id, homeAddress, string.Empty)
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
