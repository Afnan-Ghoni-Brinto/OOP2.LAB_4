using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;

        public Contact() { }

        public Contact(string name, string id, int age, string mobile, char gender)
        {
            personName = name;
            personId = id;
            this.age = age;
            mobileNumber = mobile;
            this.gender = gender;
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine(personName + " | " + mobileNumber);
        }

        public void DetectMobileOperator()
        {
            if (mobileNumber.StartsWith("017")) Console.WriteLine("GP");
            else if (mobileNumber.StartsWith("018")) Console.WriteLine("Robi");
            else Console.WriteLine("Unknown");
        }
    }
}
