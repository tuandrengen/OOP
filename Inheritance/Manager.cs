using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Manager : Employee
    {
        public int bonus { get; set; }

        public Manager(string name, string jobTitle, int salary, int bonus) : base(name, jobTitle, salary)
        {
            this.bonus = bonus;
        }
        public override void CalculateYearlySalary()
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
