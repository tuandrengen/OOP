using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class BankAccount
    {
        private double _balance;
        private double _borrowingRate;
        private double _savingsRate;
        public double balance
        {
            get { return _balance; }
            set
            {
                if (value < -100000)
                {
                    _balance = -100000;
                    throw new Exception("Balance cannot go below -100.000 money.");
                }
                else if (value > 250000)
                {
                    _balance = 250000;
                    throw new Exception("Balance cannot exceed 200.000 money.");
                }
                else
                {
                    _balance = value;
                }

            }
        }
        public double borrowingRate
        {
            get
            {
                return _borrowingRate;
            }
            set
            {
                if (value > 6)
                {
                    _borrowingRate = value / 100;
                }
                else
                {
                    _borrowingRate = 6 / 100;
                }
            }
        }
        public double savingsRate
        {
            get
            {
                return _savingsRate;
            }
            set
            {
                if (value > 2)
                {
                    _savingsRate = 2 / 100;
                }
                else if (value < 0)
                {
                    _savingsRate = 0;
                }
                else
                {
                    _savingsRate = value;
                }
            }
        }


        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public BankAccount(double balance, double borrowingRate, double savingsRate)
        {
            this.balance = balance;
            this.borrowingRate = borrowingRate;
            this.savingsRate = savingsRate;
        }

        public void depositMoney(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("Cannot deposit negative amount of money");
            }
            else
            {
                balance += money;
            }
            return;
        }

        public void withdrawMoney(double money)
        {
            if (money < 0)
            {
                throw new Exception("Cannot withdraw a negative amount of money.");
            }
            else
            {
                balance -= money;
            }
        }
    }

}
