using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace EncapsulationLab
{
    class Person
    {
        // Fields -----------------------------------------
        private string firstName, lastName;
        private int age;

        private decimal salary;
        // private static decimal bonus;

        // Properties -------------------------------------
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        // Constructor(s) ---------------------------------
        public Person(string fn, string ln, int age)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
        }

        public Person(string fn, string ln, int age, decimal salary) : this(fn, ln, age)
        {
            Salary = salary;
        }

        // Methods ----------------------------------------
        public void IncreaseSalary(decimal bonus)
        {
            if (Age < 30)
            {
                bonus /= 2;
            }
            Salary *= bonus / 100 + 1;

        }
        public override string ToString()
        {
            // return $"{FirstName} {LastName} is {Age} years old.";
            return $"{FirstName} {LastName} recieves {Salary} dollars.";
        }
    }
}