using System;

namespace SafariParkApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person cathy = new Person("Cathy", "French");
            Console.WriteLine(cathy.GetFullName());

            cathy.Age = -1;

            Console.WriteLine($"Cathy's age is {cathy.Age}");

            cathy.Age = 26;

            Console.WriteLine($"Cathy's age is {cathy.Age}");

            cathy.Age = -1;

            Console.WriteLine($"Cathy's age is {cathy.Age}");

            //Person Nish;
            //Nish = new Person("Nish", "Mandal");
            //Console.WriteLine(Nish.GetFullName());

            //var Sparta = new Spartan("Nish", "Mandal", 30);
            //var rouz = new Person();
            //var callum = new Person("Callum", "Harding");
            //var michael = new Person("Michael", "Willcock", 22);

            //var hamse = new Person("Hamse", "Ahmed") { Age = 21 };

            //var shopList = new ShoppingList() { Bread = 2, Potato = 9 };
            //shopList.Potato = 7;

            //    Person paul = new Person("Paul", "McCartney") { Age = 80 };
            //    Point_id pt3 = new Point_id(5, 8, 2);
            //    DemoMethod(pt3, paul);

            //    Point_id p;

            //    Person x;
        }

        //static void DemoMethod(Point_id pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}
    }
}
