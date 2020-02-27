using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Manager : Employee // Sub class. Child of Employee class. Inherits from the Employee class.
    {
        public int bonus { get; set; }

        public Manager(string name, string jobTitle, int salary, int bonus) : base(name, jobTitle, salary)
        {
            this.bonus = bonus;
        }
        public override void CalculateYearlySalary() // Overrides the virtual method from the Employee class.
        {
            Console.WriteLine(salary * 12 * ((10 / seniorityLevel) + 1));
        }
        public override void CalculateYearlySalaryWithBonus()
        {
            double salaryBonus = salary * 12 * ((10 / seniorityLevel) + 1) + bonus;
            Console.WriteLine(salaryBonus);
        }
    }
}
