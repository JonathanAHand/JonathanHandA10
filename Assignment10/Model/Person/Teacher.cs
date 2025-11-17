namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a teacher within the system.
    /// Inherits identity and address information from the <see cref="Person"/> class
    /// and adds an academic department field with validation rules.
    /// </summary>
    public class Teacher : Person
    {
        /// <summary>
        /// Gets or sets the department associated with the teacher.
        /// An empty string defaults to "Unknown".
        /// A null assignment results in an exception.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the assigned value is null.
        /// </exception>
        public string Department { get; set; }

        /// <summary>
        /// Private constructor used only for constructor chaining.
        /// Prevents creating uninitialized <see cref="Teacher"/> objects.
        /// </summary>
        private Teacher()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class
        /// using only the first and last name.
        /// Other values default to placeholders.
        /// </summary>
        public Teacher(string firstName, string lastName)
            : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class
        /// using the first name, last name, and teacher ID.
        /// </summary>
        public Teacher(string firstName, string lastName, int id)
            : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new <see cref="Teacher"/> with name, ID, and home address.
        /// Department defaults to an empty string.
        /// </summary>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress)
            : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new fully-specified <see cref="Teacher"/> object.
        /// Includes name, ID, home address, and department.
        /// </summary>
        /// <param name="firstName">The teacher's first name.</param>
        /// <param name="lastName">The teacher's last name.</param>
        /// <param name="id">The unique teacher ID.</param>
        /// <param name="homeAddress">The teacher's home address.</param>
        /// <param name="department">The department in which the teacher works.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="department"/> is null.
        /// </exception>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department)
            : base(firstName, lastName, id, homeAddress)
        {
            if (department == null)
                throw new ArgumentNullException(nameof(department));

            if (department == string.Empty)
                throw new ArgumentException("Department cannot be empty.", nameof(department));

            Department = department;
        }

        /// <summary>
        /// Returns a brief formatted representation of the teacher,
        /// including name, ID, and department.
        /// </summary>
        /// <returns>A formatted teacher summary string.</returns>
        public override string ToString()
        {
            return base.ToString() + $"; Department - {Department}";
        }

        /// <summary>
        /// Gets a formatted multi-line string containing
        /// the teacher’s name, ID, home address, and department.
        /// </summary>
        public override string Details
        {
            get
            {
                string addressInfo = HomeAddress != null
                    ? HomeAddress.ToString()
                    : "No Home Address";

                return $"{FirstName} {LastName} ({Id}){Environment.NewLine}" +
                       $"{addressInfo}{Environment.NewLine}" +
                       $"Department: {Department}";
            }
        }
    }
}