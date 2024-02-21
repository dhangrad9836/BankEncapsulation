using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        //private field
        private double balance = 0;

        //constructor
        public BankAccount() { }

        //method to deposit amount to current balance
        public void Deposit(double amount)
        {
            //add the deposit amount to the current balance
            balance += amount;
        }

        //method to get the users current balance
        public double GetBalance()
        {
            return balance;
        }












    }
}
