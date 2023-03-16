using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void PrintBalance()
        {
            Console.Clear();
            UI.PrintTextNL($"Balance: {balance}", ConsoleColor.Green);
            Console.ReadLine();
        }
        public void Withdraw(double amount)
        {
            Console.Clear();
            if (balance >= amount)
            {
                balance -= amount;
                UI.PrintTextNL($"{amount} have been removed from your account");
                UI.PrintTextSL($"New account balance: "); UI.PrintTextNL($"{ this.balance}", ConsoleColor.Green);
            }
            else
                UI.PrintTextNL($"Your balance of {this.balance} do not have the amount of {amount} in it.", ConsoleColor.Red);
            Console.ReadLine();
        }
        public void Deposit(double amount)
        {
            Console.Clear();
            if (amount > 0)
            {
                this.balance += amount;
                UI.PrintTextNL($"{amount} have been added to your account");
                UI.PrintTextSL($"New account balance: "); UI.PrintTextNL($"{ this.balance}", ConsoleColor.Green);
            }
            
            else
                UI.PrintTextNL($"{amount} is lower or equal to 0 and have not been " +
                    $"added to the account\n" +
                    $"Account balance: {this.balance}");
            Console.ReadLine();
        }
    }
}
