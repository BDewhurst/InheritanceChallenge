using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge {
    class Boss : Employee 
    {
        string CompanyCar {get; set;}

        public Boss(string name, string firstName, int salary, string companyCar): base (name, firstName, salary) {
            CompanyCar = companyCar;
            Console.WriteLine($"{name} earns {salary} and gets a {companyCar} with it for his company car");
        }

        public virtual void Lead() {

            Console.WriteLine($"{Name} is leading the company");

        }

    }
}