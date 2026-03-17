using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Account
    {

        private string accName;
        private string acid;
        private int balance;

        public string AccName { get; set; }
        public string Acid { get; set; }
        public int Balance { get; set; }

        public Account() { }

        public Account(string name, string id, int bal)
        {
            accName = name;
            acid = id;
            balance = bal;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount <= balance) balance -= amount;
            else Console.WriteLine("Insufficient Balance");
        }

        public void Transfer(int amount, Account receiver)
        {
            if (amount <= balance)
            {
                balance -= amount;
                receiver.balance += amount;
            }
        }


    }
}
