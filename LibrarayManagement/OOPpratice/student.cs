using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagement.OOPpratice
{
    public class student : Person
    {
        public student(int stuId, string stuName) : base(stuId, stuName)
        {
        }

        public override void showName()
        {
            Console.WriteLine($"show name of in student class:{PersonName}");
        }
    }
}
