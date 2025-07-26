using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2.Overriding
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A = {A} :: B = {B}");
        }
    }
}
