using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (value.Length < 3)
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

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (salary < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }


                salary = value;
            }
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void increasesalary(decimal percentage)
        {
            if (age > 30)
            {
                salary += salary * percentage / 100;
            }

            else
            {
                salary += salary * percentage / 200;
            }
        }
    }
}
