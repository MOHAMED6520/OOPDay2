using OOPDay2.Inheritance;
using OOPDay2.Overriding;

namespace OOPDay2
{

    #region Classes Relationships
    //class Rom
    //{
    //    public Wall wall { get; set; }
    //    public Chair[]? chairs { get; set; }
    //}
    //class Wall
    //{ 
    //}
    //class Chair
    //{

    //}
    //class Order
    //{ 
    // public Item[] items {  get; set; }
    //}

    //class Item
    //{

    //} 
    #endregion

    
    internal class Program 
    {
        #region Overloading
        //static int Sum (int x , int y)
        //{
        //    return x + y; 
        //}

        //static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        //static double Sum(double x, int y)
        //{
        //    return x + y;
        //}

        //static double Sum(double x, int y, int z)
        //{
        //    return x + y + z;
        //} 
        #endregion

        static void Main(string[] args)
        {


            #region Inheritance
            //// Inheritance
            //Parent parent = new Parent(1,2);
            //Console.WriteLine(parent);
            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1,2, 3);
            //child.Fun01();
            //child.Fun02(); 
            #endregion

            #region Overloading

            //Polymorphism

            // Overloading
            //Sum(5, 6);

            //Sum(1.2, 7);

            //Sum(1.5, 1.7); 
            #endregion

            #region overriding
            // overriding
            //TypeB typeB = new TypeB() { A =12 , B =13};

            ////typeB.A = 12;
            ////typeB.B = 13;
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);
            //typeB.Fun01();
            //typeB.Fun02(); 
            #endregion

            #region Binding
            ////Binding

            // TypeA Ref;
            // Ref = new TypeA();
            // Ref = new TypeB();

            // Ref.A = 12;
            // // Ref.B = 13; //invalid

            //// Ref.Fun01();

            // Ref.Fun02(); 

            #endregion

            #region Not Binding

            //Not Binding

            // // TypeB typeB = new TypeB();
            ////// typeB = new TypeA(); //Invalid

            //  TypeA typeA = new TypeA();
            //  //typeA = new TypeB();

            //  TypeB Ref = (TypeB) typeA; //Not Binding 
            #endregion

        }
    }
}
