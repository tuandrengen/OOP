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

            BankAccount bankAccount = new BankAccount(2000);
            Console.WriteLine(bankAccount.balance);
            bankAccount.depositMoney(-200);
            Console.WriteLine(bankAccount.balance);

            Console.ReadLine();
        }
    }
}
