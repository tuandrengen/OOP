using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Anh Tuan Truong", "Interaction Designer", 10000);
            //Employee manager = new Manager("Tommy Pham", "Executive Interaction Designer", 11000, 1000);

            //employee.CalculateYearlySalary();
            //employee.CalculateYearlySalaryWithBonus();
            //Console.WriteLine();
            //manager.CalculateYearlySalary();
            //manager.CalculateYearlySalaryWithBonus();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your job title: ");
            string jobTitle = Console.ReadLine();

            Console.Write("Enter your salary: ");
            int salary = Int32.Parse(Console.ReadLine());

            Employee employee = new Employee(name, jobTitle, salary);

            Console.WriteLine(employee.name);
            Console.WriteLine(employee.jobTitle);
            employee.CalculateYearlySalary();
            employee.CalculateYearlySalaryWithBonus();

            //BankAccount bankAccount = new BankAccount(2000);
            //Console.WriteLine(bankAccount.balance);
            //bankAccount.depositMoney(-200);
            //Console.WriteLine(bankAccount.balance);

            Console.ReadLine();
        }
    }
}
