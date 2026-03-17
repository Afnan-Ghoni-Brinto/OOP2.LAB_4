using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Book
    {
        
            private string bookName;
            private string bookAuthor;
            private string bookId;
            private string bookType;
            private int bookCopy;

            public static int bookCounter = 0;

            public Book() { }

            public Book(string name, string author, string id, string type, int copy)
            {
                bookName = name;
                bookAuthor = author;
                bookId = id;
                bookType = type;
                bookCopy = copy;
                bookCounter++;
            }

            public void ShowInfo()
            {
                Console.WriteLine(bookName + " | " + bookAuthor + " | Copies: " + bookCopy);
            }

            public void AddBookCopy(int x)
            {
                bookCopy += x;
            }

            public static void showTotalBookInfo()
            {
                Console.WriteLine("Total Books: " + bookCounter);
            }
        
    }
}
