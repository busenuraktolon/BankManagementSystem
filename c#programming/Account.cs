using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_programming
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string accountHolder, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount}. Current balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Error!Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}. Current balance: {Balance}");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Error!Insufficient funds for this withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public string GetAccountInfo()
        {
            return $"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance}";
        }
    }

}
