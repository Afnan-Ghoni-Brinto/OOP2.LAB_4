using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                
                Account a1 = new Account("Rahim", "A1", 5000);
                Account a2 = new Account("Karim", "A2", 2000);
                a1.Transfer(1000, a2);

                Book b1 = new Book("C#", "Author", "B1", "Programming", 5);

                Library lib = new Library("City Library", "Dhaka");
                lib.AddNewBook(b1);
                lib.ShowLibInfo();

                Contact c1 = new Contact("Rahim", "C1", 22, "01712345678", 'M');

                AddressBook ab = new AddressBook("My Contacts", "Personal");
                ab.AddContact(c1);
                ab.ShowAllContactInfo();

                Mobile m = new Mobile("Rahim", "01712345678", 100, "Android", false);
                m.CallSomeone(10);
                m.ShowInfo();

                Course course = new Course("OOP", "CS101", 3);
                course.ShowCourseInfo();
            
        
    }
    }
}
