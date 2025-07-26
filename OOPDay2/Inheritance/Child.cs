using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2.Inheritance
{
    internal class Child : Parent
    {
        //public Child(int x, int y) : base(1, 2)
        //{
           
        //}
        public int Z { get; set; }
        public Child(int x , int y , int z):base(x,y) 
        { 
         Z = z;
        }

        public override string ToString()
        {
            return $"X = {X} :: Y = {Y} :: Z= {Z}";
        }

        public void Fun01()
        {
            Console.WriteLine("I am Child [Sub] ");
        }

        public void Fun02()
        {
            Console.WriteLine($"X = {X} :: Y = {Y} :: Z = {Z}");
        }
    }
}
