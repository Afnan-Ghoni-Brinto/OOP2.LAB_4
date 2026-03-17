using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Mobile
    {
      
            private string mobileOwnerName;
            private string mobileNumber;
            private int mobileBalance;
            private string mobileOSName;
            private bool lockStatus;

            public Mobile() { }

            public Mobile(string name, string number, int balance, string os, bool l)
            {
                mobileOwnerName = name;
                mobileNumber = number;
                mobileBalance = balance;
                mobileOSName = os;
                lockStatus = l;
            }

            public void ShowInfo()
            {
                if (!lockStatus)
                    Console.WriteLine(mobileOwnerName + " | Balance: " + mobileBalance);
            }

            public void Recharge(int amount)
            {
                if (!lockStatus) mobileBalance += amount;
            }

            public void CallSomeone(int time)
            {
                if (!lockStatus && mobileBalance >= time)
                    mobileBalance -= time;
            }
        
    }
}
