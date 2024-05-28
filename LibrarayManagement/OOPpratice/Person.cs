using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public abstract class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }    

        public Person(int peopleId,  string peopleName)
        {
            PersonId = peopleId;
            PersonName = peopleName;
        }

        public void printName()
        {
            Console.WriteLine($"person name = {PersonName}");
        }
        public abstract void showName();

        public virtual void VirtualMethod()
        {
            Console.WriteLine($"virtual method in person class name = {PersonName}");
        }

    }
}
