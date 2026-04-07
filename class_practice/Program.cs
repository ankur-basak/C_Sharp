using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Account
    {
        private string accountHolderName;
        private string accountNumber;
        private double balance;

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            accountHolderName = " "; 
            accountNumber = " ";
            balance = 0.0;
        }

        public Account(string name, string accNumber, double currentBalance)
        {
            accountHolderName = name;
            accountNumber = accNumber;
            balance = currentBalance;
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
        }

        public void Deposit(double amount)
        {
            if (amount > 500)
            {
                balance += amount;
                Console.WriteLine("Deposit successful. New balance: " + balance);

            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 500)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful. New balance: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public void Transfer(Account recipientAccount, double amount)
        {
            if (amount > 99)
            {
                balance -= amount;
                recipientAccount.Deposit(amount);
                Console.WriteLine("Transfer successful. New balance: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid transfer amount or insufficient funds.");
            }
        }
    }

    class Start
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Ankur Basak", "24657987", 4050.60);
            Account acc2 = new Account("Ronaldo", "123456777", 5000.00);

            acc1.DisplayAccountDetails();
            acc2.DisplayAccountDetails();

            acc1.Deposit(2000);
            acc1.Withdraw(700);
            acc1.Transfer(acc2, 400);

            acc1.DisplayAccountDetails();
            acc2.DisplayAccountDetails();

            Console.ReadLine();
        }
    }
}
