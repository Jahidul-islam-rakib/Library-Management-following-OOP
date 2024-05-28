using LibrarayManagement.OOPpratice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            library Library = new library();
            books book1 = new books(1 , "c++ Giant");
            books book2 = new books(2, "tech c");

            bookShelf bShelft1 = new bookShelf(1, "Bengal");

            student st1 = new student(2, "Rakib");
            student st2 = new student(3, "Hasan");

            Librarian admin1 = new Librarian(1, "aminul");

            Library.AddPerson(st1);
            Library.AddPerson(st2);
            Library.AddPerson(admin1);


            Library.AddItem(book2);
            Library.AddItem(book1);
            Library.AddItem(bShelft1);

            Library.printItemOfLibrary();

            Library.printPersonOfLibrary();







            Console.WriteLine("hi there");
        }
    }
}
