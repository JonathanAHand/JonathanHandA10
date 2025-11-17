namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a student within the system.
    /// Inherits base identity and address information from the <see cref="Person"/> class.
    /// </summary>
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        private string _major;
        private string _minor;

        /// <summary>
        /// Gets or sets the student's major.
        /// If an empty string is assigned, the value defaults to <c>Undeclared</c>.
        /// A null assignment results in an exception.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the value assigned to <see cref="Major"/> is null.
        /// </exception>
        public string Major
        {
            get => _major;
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

        /// <summary>
        /// Gets or sets the student's minor.
        /// If an empty string is assigned, the value defaults to <c>Undeclared</c>.
        /// A null assignment results in an exception.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the value assigned to <see cref="Minor"/> is null.
        /// </exception>
        public string Minor
        {
            get => _minor;
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

        /// <summary>
        /// Gets a formatted string containing detailed information about the student.
        /// Includes name, ID, major, optional minor, and full home address if available.
        /// </summary>
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

        /// <summary>
        /// Private parameterless constructor used only for internal chaining.
        /// Prevents the creation of uninitialized <see cref="Student"/> objects.
        /// </summary>
        private Student()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// using the first and last name. Other values default to placeholders.
        /// </summary>
        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// using the first name, last name, and ID.
        /// Other values default to placeholders.
        /// </summary>
        public Student(string firstName, string lastName, int id)
            : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// using the first name, last name, ID, and home address.
        /// Major defaults to an empty string (which becomes <c>Undeclared</c>).
        /// </summary>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress)
            : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// using full identity information and a declared major.
        /// Minor defaults to <c>Undeclared</c>.
        /// </summary>
        /// <param name="firstName">The student's first name.</param>
        /// <param name="lastName">The student's last name.</param>
        /// <param name="id">The unique student ID.</param>
        /// <param name="homeAddress">The student's home address.</param>
        /// <param name="major">The declared academic major.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="major"/> is null.
        /// </exception>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major)
            : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        /// <summary>
        /// Returns a brief formatted string containing the student's name,
        /// ID, and major.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + $"; Major - {Major}";
        }
    }
}
