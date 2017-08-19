using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[1];
                string bank = inputTokens[0];
                decimal balance = decimal.Parse(inputTokens[2]);

                bankAccounts.Add(new BankAccount(name, bank, balance));

                input = Console.ReadLine();
            }

            bankAccounts = bankAccounts.OrderByDescending(b => b.Balance).ThenBy(b => b.Bank.Length).ToList();

            foreach (BankAccount bankAccount in bankAccounts)
            {
                Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
            }
        }
    }

    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string name, string bank, decimal balance)
        {
            this.Name = name;
            this.Bank = bank;
            this.Balance = balance;
        }
    }
}
