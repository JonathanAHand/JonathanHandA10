namespace Assignment10.Model.Person
{
    public class Staff : Person
    {
        public string Title { get; set; }

        private Staff()
        {
        }

        public Staff(string firstName, string lastName)
            : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Staff(string firstName, string lastName, int id)
            : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Staff(string firstName, string lastName, int id, Address.Address homeAddress)
            : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title)
            : base(firstName, lastName, id, homeAddress)
        {
            if (title == null)
                throw new ArgumentNullException(nameof(title), "Title cannot be null.");

            if (title == string.Empty)
                throw new ArgumentException("Title cannot be an empty string.", nameof(title));

            Title = title;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Title - {Title}";
        }

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