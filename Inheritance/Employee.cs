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
                else if (value <= 1)
                {
                    _seniorityLevel = 1;
                }
                else
                    _seniorityLevel = value;
            }
        }

        public Employee(string name, string jobTitle, int salary) // Contructor
        {
            this.name = name;
            this.jobTitle = jobTitle;
            this.salary = salary;
            seniorityLevel = 1;
        }
        // Virtual methods can reside in abstract and non-abstract classes
        // It is not necessary to override virtual methods in subclasses
        // Virtual methods must have an implementation, which CAN be overriden in the subclass
        public virtual void CalculateYearlySalary() // Virtual method
        {
            Console.WriteLine($"{name} gets " + salary * 12 + $" money every year as an {jobTitle}.");
        }
        public virtual void CalculateYearlySalaryWithBonus()
        {
            int salaryBonus;
            if (seniorityLevel > 0)
            {
                salaryBonus = salary * 12 * ((10 / seniorityLevel) + 1);
            }
            else
            {
                salaryBonus = salary;
            }

            Console.WriteLine(salaryBonus);
        }
    }
}
