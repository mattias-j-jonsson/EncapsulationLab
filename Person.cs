using System;
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
                if(value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
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
                if(value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer");
                }
                age = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set 
            {
                if (value.CompareTo((decimal) 460.0) <= 0)
                {
                    throw new ArgumentException("Salary has to be greater than 460 dollars (you monster)");
                }
                salary = value;
            }
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