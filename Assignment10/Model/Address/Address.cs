namespace Assignment10.Model.Address
{
    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public Address() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        public Address(string street, string city, string state, int zip)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip;
        }

        public override string ToString()
        {
            return $"{Street}{Environment.NewLine}" +
                   $"{City}, {State} {Zip}";
        }
    }
}