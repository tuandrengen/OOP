using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Anh Tuan Truong", "Interaction Designer", 3, 20000);
            Employee manager = new Manager("Tommy Pham", "Executive Interaction Designer", 2, 22000, 1000);

            employee.CalculateYearlySalary();
            employee.CalculateYearlySalaryWithBonus();
            Console.WriteLine();
            manager.CalculateYearlySalary();
            manager.CalculateYearlySalaryWithBonus();
            Console.ReadLine();
        }
    }
}
