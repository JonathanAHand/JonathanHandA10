namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a staff member within the system.
    /// Inherits common identity and address information from the <see cref="Person"/> class.
    /// </summary>
    public class Staff : Person
    {
        /// <summary>
        /// Gets or sets the job title of the staff member.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Private default constructor used to prevent parameterless instantiation.
        /// Constructor chaining is used instead to ensure required data is provided.
        /// </summary>
        private Staff()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class using the
        /// first and last name. Other values default to placeholder settings.
        /// </summary>
        /// <param name="firstName">The staff member's first name.</param>
        /// <param name="lastName">The staff member's last name.</param>
        public Staff(string firstName, string lastName)
            : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class using
        /// first name, last name, and ID. Other values default to placeholder settings.
        /// </summary>
        /// <param name="firstName">The staff member's first name.</param>
        /// <param name="lastName">The staff member's last name.</param>
        /// <param name="id">The unique identifier for the staff member.</param>
        public Staff(string firstName, string lastName, int id)
            : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class using
        /// name, ID, and home address. Title defaults to an empty string.
        /// </summary>
        /// <param name="firstName">The staff member's first name.</param>
        /// <param name="lastName">The staff member's last name.</param>
        /// <param name="id">The unique identifier for the staff member.</param>
        /// <param name="homeAddress">The staff member's home address.</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress)
            : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class using
        /// full person information including job title.
        /// Validates that the title is neither null nor an empty string.
        /// </summary>
        /// <param name="firstName">The staff member's first name.</param>
        /// <param name="lastName">The staff member's last name.</param>
        /// <param name="id">The unique identifier for the staff member.</param>
        /// <param name="homeAddress">The staff member's home address.</param>
        /// <param name="title">The job title of the staff member.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="title"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="title"/> is an empty string.</exception>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title)
            : base(firstName, lastName, id, homeAddress)
        {
            if (title == null)
                throw new ArgumentNullException(nameof(title), "Title cannot be null.");

            if (title == string.Empty)
                throw new ArgumentException("Title cannot be an empty string.", nameof(title));

            Title = title;
        }

        /// <summary>
        /// Returns a basic string representation of the staff member,
        /// including name, ID, and title.
        /// </summary>
        /// <returns>A formatted string containing name, ID, and title.</returns>
        public override string ToString()
        {
            return base.ToString() + $"; Title - {Title}";
        }

        /// <summary>
        /// Gets a formatted, detailed string describing the staff member.
        /// Includes their name, ID, title, and full home address (if available).
        /// </summary>
        public override string Details
        {
            get
            {
                string addressInfo = HomeAddress != null
                    ? HomeAddress.ToString()
                    : "No Home Address";

                return $"{FirstName} {LastName} ({Id}/{Title}){Environment.NewLine}" +
                       $"{addressInfo}";
            }
        }
    }
}