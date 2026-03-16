using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._2
{
    internal class Book
    {
        private String bookName, bookAuthor, bookId, bookType;
        private int bookCopy;
        public static int bookCounter=0;
        public Book() { }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            bookCounter++;
        }
        public String BN
        {
            get { return bookName; }
            set { this.bookName = value; }
        }
        public String BA
        {
            get { return bookAuthor; }
            set { this.bookAuthor = value; }
        }
        public String BI
        {
            get { return bookId; }
            set { this.bookId = value; }
        }
        public String BT
        {
            get { return bookType; }
            set { this.bookType = value; }
        }
        public int BC
        {
            get { return bookCopy; }
            set { this.bookCopy = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("BOOK NAME : " + this.bookName);
            Console.WriteLine("AUTHOR : " + this.bookAuthor);
            Console.WriteLine("ID : " + this.bookId);
            Console.WriteLine("TYPE : " + this.bookType);
            Console.WriteLine("COPY : " + this.bookCopy);
            Console.WriteLine();
        }
        public void AddBookCopy(int x)
        {
            this.bookCopy += x;
            Console.WriteLine("Total : "+this.bookCopy);
        }
        public static void showTotalBookInfo()
        {
            Console.WriteLine("Total Books: " + bookCounter);
        }
    }
}
