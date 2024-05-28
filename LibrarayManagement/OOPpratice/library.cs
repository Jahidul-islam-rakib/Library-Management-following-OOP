using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public class library
    {
        public List<item> Items = new List<item>();
        public List<Person> ItemPerson = new List<Person>();

        public void AddItem(item itm)
        {
            Items.Add(itm);
            Console.WriteLine($"item has been added : {itm.bookName}");
        }

        public void AddPerson(Person ple)
        {
            ItemPerson.Add(ple);
            Console.WriteLine($"person has been added : {ple.PersonName}");
        }

        public void printItemOfLibrary()
        {
            Console.WriteLine("items are:");
            foreach (item itm in Items)
            {
                Console.WriteLine($"item : {itm.bookName}");
            }

            Console.WriteLine("----------------------***------------------");
        }

        public void printPersonOfLibrary()
        {
            Console.WriteLine("persons are:");
            foreach (Person ple in ItemPerson)
            {
                Console.WriteLine($"Person : {ple.PersonName}");
            }


        }
    }

    }
