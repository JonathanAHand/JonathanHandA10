namespace Assignment10.Model.Person
{

    public class Person
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Id { get; set; }
        
        public Address.Address HomeAddress { get; set; }

        protected Person()
        {
        }

        public Person(string firstName, string lastName) : this(firstName, lastName, 0, null)
        {
        }

        public Person(string firstName, string lastName, int id) : this(firstName, lastName, id, null)
        {
        }

        public Person(string firstName, string lastName, int id, Address.Address homeAddress)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Id = id;
            HomeAddress = homeAddress;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}
