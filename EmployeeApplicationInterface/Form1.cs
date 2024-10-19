using EmployeeNamespace;
namespace EmployeeApplicationInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BSalary_Click(object sender, EventArgs e)
        {
            PartTimeEmployee parttime = new PartTimeEmployee(TBFirstName.Text, TBLastName.Text, TBDepartment.Text, TBJobTitle.Text);//getting the valaues in text box
            if (string.IsNullOrWhiteSpace(TBFirstName.Text) || string.IsNullOrWhiteSpace(TBLastName.Text) || string.IsNullOrWhiteSpace(TBDepartment.Text) || string.IsNullOrWhiteSpace(TBJobTitle.Text) || string.IsNullOrWhiteSpace(TBRatePerHour.Text) || string.IsNullOrWhiteSpace(TBTotalHoursWorked.Text))
            {
                MessageBox.Show("Need all information to compute your salary.");
            }
            else
            {
                int hoursWorked = int.Parse(TBTotalHoursWorked.Text);//converts the string value into int
                double ratePerHour = double.Parse(TBRatePerHour.Text);  //converts string to double
                parttime.computeSalary(hoursWorked, ratePerHour); //setting the value of rate and total 
                LBFirstName.Text = "First Name: " + parttime.FirstName; // setting the label the text input
                LBLastName.Text = "Last Name: " + parttime.LastName;
                LBSalary.Text = "Basic salary: " + parttime.getSalary(); // setting the label the salary total
            }
        }
    }
}
namespace EmployeeInterface //the namespace of interface class
{
    public interface IEmployee
    {
        string FirstName { get; set; } //the properties
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }
        void computeSalary(int HoursWorked, double RatePerHour);

    }
}


namespace EmployeeNamespace //namespace of employee class
    {
    using EmployeeInterface; // using the interface namespace
    using System.CodeDom;

    public class PartTimeEmployee : IEmployee //inheritance
        {
            private string first_name; //declaration of variables
            private string last_name;
            private string department;
            private string job_title;
            private double basic_salary;

        public PartTimeEmployee (string Fname, string Lname, string dept, string job)// the constructor
        {
            this.first_name = Fname;
            this.last_name = Lname;
            this.department = dept;
            this.job_title = job;
        }
        public string FirstName // using properties 
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }

        public double BasicSalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        public void computeSalary(int HoursWorked, double RatePerHour) {//method to compute the basic salary

            this.basic_salary = HoursWorked * RatePerHour;
           
        }
        public double getSalary() //this one will return the computed salary
        {
            return this.basic_salary;
        }
        }
    }
