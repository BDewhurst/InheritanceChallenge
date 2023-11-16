using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge {
    class Trainee : Employee 
    {
        int WorkingHours {get; set;}
        int SchoolHours {get; set;}

        public Trainee(string name, string firstName, int salary, int schoolHours, int workingHours): base (name, firstName, salary) {

            SchoolHours = schoolHours;
            WorkingHours = workingHours;
            Console.WriteLine($"{name} earns {salary}");
     
        }

        public virtual void Learn() {
         
            Console.WriteLine($"{Name} has {SchoolHours} a week");
            
        }

        // Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

        public override void Work()
        {
            WorkingHours = SchoolHours - WorkingHours;
            Console.WriteLine($"Overall, {Name} works {WorkingHours} a week");
        }

    }
}