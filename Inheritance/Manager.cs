using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Manager : Employee
    {
        public int bonus { get; set; }

        public Manager(string name, string jobTitle, int seniorityLevel, int salary, int bonus) : base(name, jobTitle, seniorityLevel, salary)
        {
            this.name = name;
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.seniorityLevel = seniorityLevel;
            this.bonus = bonus;
        }
        public override void CalculateYearlySalary()
        {
            Console.WriteLine(salary * 12 + bonus);
        }

        public override void CalculateYearlySalaryWithBonus()
        {
            Console.WriteLine(salary * 12 + (salary * 12) / (seniorityLevel * 10) + bonus);
        }
    }
}
