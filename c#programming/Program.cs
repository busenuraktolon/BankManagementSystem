using c_programming;
using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nBank Management System");
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. View All Accounts");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Account Holder Name: ");
                    string accountHolder = Console.ReadLine();
                    bank.CreateAccount(accountNumber, accountHolder);
                    break;

                case 2:
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Deposit Amount: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    bank.DepositToAccount(accountNumber, depositAmount);
                    break;

                case 3:
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Withdrawal Amount: ");
                    double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                    bank.WithdrawFromAccount(accountNumber, withdrawalAmount);
                    break;

                case 4:
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    bank.CheckBalance(accountNumber);
                    break;

                case 5:
                    bank.ViewAccounts();
                    break;

                case 6:
                    exit = true;
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

