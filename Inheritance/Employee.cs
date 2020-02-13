using System;

namespace Inheritance
{
    class Employee // base class. Parent of the Manager class.
    {
        private int _seniorityLevel;
        public string name { get; set; }
        public string jobTitle { get; set; }
        public int salary { get; set; }
        public int seniorityLevel
        {
            get
            {
                return _seniorityLevel;
            }
            set
            {
                if (value > 10)
                {
                    _seniorityLevel = 10;
                }
                else if (value < 1)
                {
                    _seniorityLevel = 1;
                }
                else
                    _seniorityLevel = value;
            }
        }

        public Employee(string name, string jobTitle, int salary)
        {
            this.name = name;
            this.jobTitle = jobTitle;
            this.seniorityLevel = seniorityLevel;
            this.salary = salary;
        }

        public virtual void CalculateYearlySalary()
        {
            Console.WriteLine($"{name} gets " + salary * 12 + $" money every year as an {jobTitle}.");
        }

        public virtual void CalculateYearlySalaryWithBonus()
        {
            double salaryBonus = salary * 12 * ((10/seniorityLevel)+1);
            Console.WriteLine(salaryBonus);
        }
    }
}
