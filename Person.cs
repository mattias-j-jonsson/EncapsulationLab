using System.Runtime.CompilerServices;

namespace EncapsulationLab
{
    class Person
    {
        private string firstName, lastName;
        private int age;

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
            get {return age;}
            private set {age = value;}
        }

        public Person(string fn, string ln, int age)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}