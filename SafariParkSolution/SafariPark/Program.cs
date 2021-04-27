using System;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person cathy = new Person("Cathy", "French");
            //Console.WriteLine(cathy.GetFullName());
            //cathy.Age = -1;
            //Console.WriteLine("Cathy's Age: " + cathy.Age);
            //cathy.Age = 26;
            //Console.WriteLine("Cathy's Age: " + cathy.Age);
            //cathy.Age = -1;
            //Console.WriteLine("Cathy's Age: " + cathy.Age);

            //Person nish;
            //nish = new Person("Nish", "Mandal");
            //Console.WriteLine(nish.GetFullName());

            //var spartan = new Spartan {FirstName = "Nish", LastName = "Mandal", Age = 30 };
            //var age = spartan.Age;


            //var rouz = new Person();
            //rouz.Age = 22;
            //var callum = new Person("Callum", "Harding");
            //var michael = new Person("Michael", "Willcock", 22);

            //var hamse = new Person("Hamse", "Ahmed") { Age = 21 };

            //var shopList = new ShoppingList() { Bread = 2, Potato = 9 };
            //shopList.Potato = 7;

            //var shopList2 = new ShoppingList { Soap = 2 };

            // Point3d p;


            Person paul = new Person("Paul", "McCartney") { Age = 80 };
            Point3d pt3d = new Point3d(5, 8, 2);
            DemoMethod(pt3d, paul);
            
        }

        static void DemoMethod(Point3d pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
