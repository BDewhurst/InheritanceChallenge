﻿
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
    class Program {
    static void Main(string[] args) {

        Employee Employee1 = new Employee("De Beauvoir", "Simone", 500);
        Boss Boss1 = new Boss("Camus", "Albert", 600, "Ford Fiesta");
        Trainee Trainee1 = new Trainee("Sartre", "Jean-Paul", 600, 12, 4);
        Trainee1.Work();
        Boss1.Lead();
        Trainee1.Learn();
        

        }
    }
}