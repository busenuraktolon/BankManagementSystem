using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_programming
{
   public class Bank
{
    private Account[] accounts = new Account[50];
    private int accountCount = 0;

    public void CreateAccount(int accountNumber, string accountHolder)
    {
        if (accountCount >= 50)
        {
            Console.WriteLine("Bank cannot hold more accounts.");
            return;
        }

        foreach (var account in accounts)
        {
            if (account != null && account.AccountNumber == accountNumber)
            {
                Console.WriteLine("An account with this number already exists.");
                return;
            }
        }

        accounts[accountCount++] = new Account(accountNumber, accountHolder);
        Console.WriteLine("Account created successfully.");
    }

    public void DepositToAccount(int accountNumber, double amount)
    {
        var account = FindAccount(accountNumber);
        if (account != null)
        {
            account.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void WithdrawFromAccount(int accountNumber, double amount)
    {
        var account = FindAccount(accountNumber);
        if (account != null)
        {
            account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void CheckBalance(int accountNumber)
    {
        var account = FindAccount(accountNumber);
        if (account != null)
        {
            Console.WriteLine($"Current balance: {account.Balance}");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void ViewAccounts()
    {
        if (accountCount == 0)
        {
            Console.WriteLine("No accounts found.");
            return;
        }

        foreach (var account in accounts)
        {
            if (account != null)
            {
                Console.WriteLine(account.GetAccountInfo());
            }
        }
    }

    private Account FindAccount(int accountNumber)
    {
        foreach (var account in accounts)
        {
            if (account != null && account.AccountNumber == accountNumber)
            {
                return account;
            }
        }
        return null;
    }
}

}
