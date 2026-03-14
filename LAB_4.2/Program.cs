using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("OOP in C#", "John Smith", "B101", "Programming", 5);

            Console.WriteLine("Book Information:");
            b1.ShowInfo();

            Console.WriteLine("\nAdding Copies...");
            b1.AddBookCopy(3);

            Console.WriteLine("\nUpdated Book Information:");
            b1.ShowInfo();

            Book.showTotalBookInfo();
            Contact c1 = new Contact("Rahim", "C101", 22, "017******", 'M');

            Console.WriteLine("\nContact Information:");
            c1.ShowPersonInfo();

            Console.WriteLine("Mobile Operator:");
            c1.DetectMobileOperator();
        }
    }
}
