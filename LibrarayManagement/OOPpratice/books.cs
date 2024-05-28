using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public class books : item
    {

        public books(int idN, string titleBook) : base(idN, titleBook) 
            // constructor e child o base er parameter same howa lagbe
        {
        }

        public override void displayBookName()
            // polymorphism
        {
            Console.WriteLine($"Id = {Id} ,book name= {bookName}");
        }

    }
}
