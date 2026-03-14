using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._2
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
            this.personName = name;
            this.personId = id;
            this.age = age;
            this.mobileNumber = mobile;
            this.gender = gender;
        }
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        public string PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Name: " + personName);
            Console.WriteLine("ID: " + personId);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Mobile: " + mobileNumber);
            Console.WriteLine("Gender: " + gender);
        }
        public void DetectMobileOperator()
        {
            if (mobileNumber.StartsWith("017"))
                Console.WriteLine("Operator: GP");
            else if (mobileNumber.StartsWith("018"))
                Console.WriteLine("Operator: Robi");
            else
                Console.WriteLine("Operator Unknown");
        }
    }
}
