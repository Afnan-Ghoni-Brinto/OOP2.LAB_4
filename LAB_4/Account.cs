using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB_4
{
    internal class Account
    {
        private String accName, acid;
        private int balance;
        public Account(String accName, String acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public String ACC
        {
            get { return accName; }
            set { this.accName = value; }
        }
        public String ACID
        {
            get { return acid; }
            set { this.acid = value; }
        }
        public int BA
        {
            get { return balance; }
            set { this.balance = value; }
        }
        public void Deposit(int a)
        {
            this.balance += a;
            Console.WriteLine("Total balance:" + this.balance);
        }
        public void Withdraw(int a)
        {
            if (this.balance >= a)
            {
                this.balance -= a;
                Console.WriteLine("Total Balance:" + this.balance);
            }
            else
            {
                Console.WriteLine("Low balance");
            }
        }
        public void Transfer(int amount, Account receiver)
        {
            if (amount <= balance)
            {
                balance -= amount;
                receiver.balance += amount;
                Console.WriteLine("Transfer Successful");
            }
            else
            {
                Console.WriteLine("Transfer Failed: Insufficient Balance");
            }
        }
    }
}
