namespace Assignment10.Model.Person
{
    public class Teacher : Person
    {
        public string Department { get; set; }

        private Teacher()
        {
        }

        public Teacher(string firstName, string lastName)
            : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id)
            : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress)
            : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department)
            : base(firstName, lastName, id, homeAddress)
        {
            if (department == null)
                throw new ArgumentNullException(nameof(department));

            if (department == string.Empty)
                throw new ArgumentException("Department cannot be empty.", nameof(department));

            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Department - {Department}";
        }

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