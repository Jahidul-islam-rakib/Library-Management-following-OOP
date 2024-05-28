using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public abstract class item
    {
        public  int Id { get; set; }
        public string bookName { get; set; }
        public abstract void displayBookName();

        protected item(int id , string title)
        {
            Id = id;
            bookName = title;
        }
    }
}
