namespace Assignment10.Model.Address
{
    /// <summary>
    /// Represents a physical mailing address that includes street,
    /// city, state, and zip code information.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street portion of the address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the city portion of the address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state portion of the address.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the ZIP code for the address.
        /// </summary>
        public int Zip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class
        /// using default placeholder values.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class
        /// with the specified street, city, state, and ZIP code.
        /// </summary>
        /// <param name="street">The street name or number.</param>
        /// <param name="city">The city name.</param>
        /// <param name="state">The state abbreviation.</param>
        /// <param name="zip">The ZIP code.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="street"/>, <paramref name="city"/>,
        /// or <paramref name="state"/> is null.
        /// </exception>
        public Address(string street, string city, string state, int zip)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip;
        }

        /// <summary>
        /// Returns a formatted string representation of the address,
        /// including street, city, state, and ZIP code.
        /// </summary>
        public override string ToString()
        {
            return $"{Street}{Environment.NewLine}" +
                   $"{City}, {State} {Zip}";
        }
    }
}