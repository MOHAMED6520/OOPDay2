using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int NumOfHour { get; set; }

        public int PriceOfHour { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("I am Part Time Employee ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"Salary = {NumOfHour*PriceOfHour}");
        }
    }
}
