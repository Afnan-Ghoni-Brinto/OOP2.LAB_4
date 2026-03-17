using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Library
    {
        private string libName;
        private string libAddress;
        private Book[] listOfBook = new Book[100];
        private int totalBook = 0;

        public Library() { }

        public Library(string name, string address)
        {
            libName = name;
            libAddress = address;
        }

        public void AddNewBook(Book b)
        {
            listOfBook[totalBook++] = b;
        }

        public void ShowLibInfo()
        {
            Console.WriteLine(libName + " - " + libAddress);
            for (int i = 0; i < totalBook; i++)
                listOfBook[i].ShowInfo();
        }

    }
}
