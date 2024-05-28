using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public class Librarian : Person
    {
        public Librarian(int LibrarianId, string LibrarianName) : base(LibrarianId, LibrarianName)
        {
        }

        public override void showName()
        {
            Console.WriteLine($"Librarian name in librarian class = {PersonName}");

        }

    }
}
