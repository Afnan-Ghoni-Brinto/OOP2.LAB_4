using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class AddressBook
    {
        private string ownerName;
        private string info;
        private Contact[] list = new Contact[100];
        private int count = 0;

        public AddressBook() { }

        public AddressBook(string name, string info)
        {
            ownerName = name;
            this.info = info;
        }

        public void AddContact(Contact c)
        {
            list[count++] = c;
        }

        public void ShowAllContactInfo()
        {
            for (int i = 0; i < count; i++)
                list[i].ShowPersonInfo();
        }
    }
}
