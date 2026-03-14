using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Account a = new Account("AFNAN", "240", 10);
            a.Deposit(2);
            a.Deposit(3);
            a.Withdraw(5);
            a.Withdraw(100);
            Console.WriteLine("2");
            Account a1 = new Account("Waffi", "280", 1000);
            a1.Withdraw(500);

            a.Transfer(400, a1);
            

        }
    }
}