using Assignment10.Model.Address;
using Assignment10.Model.Person;
using System.Text;

namespace Assignment10.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Demo();
        }

        private void Demo()
        {
            var studentAddress = new Address("123 Some St", "Somewhere", "GA", 55555);
            var teacherAddress = new Address("42 Campus Drive", "Carrollton", "GA", 30118);
            var staffAddress = new Address("900 University Ave", "Carrollton", "GA", 30117);

            var student = new Student("Christopher Walken", "Smith", 555111, studentAddress, "Villainry");
            student.Minor = "Mathematics";


            var teacher = new Teacher("Michael", "Jordan", 444222, teacherAddress, "Sports Science");

            var staff = new Staff("Marky", "Mark", 333777, staffAddress, "Sound Tech");

            List<Person> people = new List<Person>
            {
                student,
                teacher,
                staff
            };

            StringBuilder sb = new StringBuilder();

            foreach (Person person in people)
            {
                sb.AppendLine(person.Details);
                sb.AppendLine();
            }
            outputTextBox.Text = sb.ToString();
        }
    }
}