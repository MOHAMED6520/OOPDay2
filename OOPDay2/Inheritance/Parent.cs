using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x , int y) 
        { 
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X = {X} :: Y = {Y}";
        }

        public void Fun01()
        {
            Console.WriteLine("I am Parent [base] ");
        }

        public void Fun02()
        {
            Console.WriteLine($"X = {X} :: Y = {Y}");
        }
    }
}
