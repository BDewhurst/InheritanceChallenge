
// Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().

// Create a deriving class boss with the property CompanyCar and the method Lead().  Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().

// Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

// Don’t forget to create constructors.

// Create an object of each of the three classes (with arbitrary values)

// and call the methods, Lead() of Boss and Work() of Trainee.

// Just print out the respective text, what the respective employees do.
// E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.
using System;

namespace InheritanceChallenge
{
    class Employee
    {
        public string Name { get; set; }

        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;

            Console.WriteLine($"{Name} has a salary of {Salary} a week");

        }

        public virtual void Work()
        {

        }
        public virtual void Pause()
        {

        }
    }
}