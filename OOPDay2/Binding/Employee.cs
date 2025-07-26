using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2.Binding
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public void Fun01()
        {
            Console.WriteLine("I am Employee ");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"Salary = ???");
        }
    }
}
