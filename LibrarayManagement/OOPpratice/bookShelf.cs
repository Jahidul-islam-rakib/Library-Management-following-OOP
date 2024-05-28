using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public class bookShelf : item
    {
        public bookShelf(int id, string title) : base(id, title)
        {
        }

        public override void displayBookName()
        {
            Console.WriteLine($"bookshelf id= {Id} , bookshelf name= {bookName}"); 
        }
    }
}
