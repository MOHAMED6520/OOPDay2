using OOPDay2.Binding;
using OOPDay2.Inheritance;
using OOPDay2.Overriding;
using ClassLibrary1;
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


    internal class Program : Class1
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

        //static void EmployeeProcess (FullTimeEmployee employee)
        //{
        //    employee.Fun01();
        //    employee.Fun02();
        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    employee.Fun01();
        //    employee.Fun02();
        //}

        static void EmployeeProcess(Employee employee)
        {
            if (employee is not null)
            {
                employee.Fun01();
                employee.Fun02();
            }
        }
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

            #region When U Need Binding
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            // ID = 1,
            // Name = "Mohamed",
            // Address = "Cairo",
            // Email = "mo@gm.c",
            // Salary =12000

            //};

            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    ID = 1,
            //    Name = "Mohamed",
            //    Address = "Cairo",
            //    Email = "mo@gm.c",
            //    NumOfHour = 20,
            //    PriceOfHour = 200,

            //};

            //EmployeeProcess (fullTime);
            //EmployeeProcess (partTime); 
            #endregion

            #region Binding Example
            //TypeC typeA;

            //// typeA = new TypeA();
            ////typeA = new TypeB();
            ////typeA = new TypeC();
            //typeA = new TypeD();

            //typeA.A = 12;
            ////typeA.B = 5;
            ////typeA.C = 5;
            ////typeA.D = 5;

            //typeA.Fun01();
            //typeA.Fun02(); 
            #endregion

          

            Program class1 = new Program();
             void fun()
            { class1.X = 5; }

        }
    }
}



