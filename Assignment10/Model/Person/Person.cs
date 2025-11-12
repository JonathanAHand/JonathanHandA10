namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a base class for all people in the system.
    /// This abstract class defines shared properties and constructors 
    /// that are common to all derived person types (such as Student, Teacher, or Staff).
    /// </summary>
    /// <remarks>
    /// This class cannot be instantiated directly. 
    /// It provides a base structure for derived classes to inherit 
    /// and enforces the implementation of the abstract <see cref="Details"/> property.
    /// </remarks>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the home address of the person.
        /// </summary>
        public Address.Address HomeAddress { get; set; }

        /// <summary>
        /// Gets a formatted string that contains detailed information 
        /// about the person. This property is abstract and must be implemented 
        /// by all non-abstract derived classes.
        /// </summary>
        public abstract string Details { get; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Default protected constructor used for inheritance.
        /// </summary>
        protected Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class 
        /// with a specified first and last name.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        protected Person(string firstName, string lastName) : this(firstName, lastName, 0, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class 
        /// with a specified first and last name, and an ID.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="id">The unique ID of the person.</param>
        protected Person(string firstName, string lastName, int id) : this(firstName, lastName, id, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class 
        /// with a specified first name, last name, ID, and home address.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="id">The unique ID of the person.</param>
        /// <param name="homeAddress">The home address of the person.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="firstName"/> or <paramref name="lastName"/> is null.
        /// </exception>
        protected Person(string firstName, string lastName, int id, Address.Address homeAddress)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Id = id;
            HomeAddress = homeAddress;
        }

        /// <summary>
        /// Returns a brief string version of the Person object.
        /// </summary>
        /// <returns>String containing name and ID information.</returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}
