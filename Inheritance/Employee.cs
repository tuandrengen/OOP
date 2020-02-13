using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Employee // base class. Parent of the Manager class.
    {
        public string name { get; set; }
        public string jobTitle { get; set; }
        public int salary { get; set; }
        public int seniorityLevel { get; set; }

        public Employee(string name, string jobTitle, int seniorityLevel, int salary)
        {
            this.name = name;
            this.jobTitle = jobTitle;
            this.seniorityLevel = seniorityLevel;
            this.salary = salary;
        }

        public virtual void CalculateYearlySalary()
        {
            Console.WriteLine(salary * 12);
        }

        public virtual void CalculateYearlySalaryWithBonus()
        {
            Console.WriteLine(salary * 12 + (salary * 12) / (seniorityLevel * 10));
        }
    }
}
