using System;
using System.Collections;
using System.Collections.Generic;
using ClassesApp;

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


            //Person paul = new Person("Paul", "McCartney") { Age = 80 };
            //Point3d pt3d = new Point3d(5, 8, 2);
            //DemoMethod(pt3d, paul);

            //Hunter h = new Hunter("Hossain", "Ghazal", "Leica") { Age = 22 };
            //Hunter h2 = new Hunter("Hossain", "Ghazal", "Leica") { Age = 22 };

            //Console.WriteLine($"{h} Equals {h2}? {h.Equals(h2)}");
            //Console.WriteLine($"{h} Hascode {h.GetHashCode()}");
            //Console.WriteLine($"{h} ToString");

            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());

            //var rectangle1 = new Rectangle { Width = 10, Height = 10 };
            //var rectangle2 = new Rectangle { Width = 15, Height = 10 };

            //var totalArea = 0;

            //var shapeList = new List<Shape> { rectangle1, rectangle2 };



            //foreach (var x in shapeList)
            //{
            //    totalArea = x.CalculateArea();
            //}

            //Airplane a = new Airplane(200, 100, "JetRUs") { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);

            //a.Descend(200);
            //Console.WriteLine(a.Move());

            //a.Move();
            //Console.WriteLine(a);

            //var gameObject = new List<Object>()
            //{
            //    new Person ("Nish", "Mandal"),
            //    new Airplane (400, 200, "Virgin Flights"),
            //    new Hunter("Tim", "Burton", "Nikon")
            //};

            //gameObject.ForEach(x => Console.WriteLine(x));

            //var liam = new Person("Liam", "Gallagher");
            //SpartaWrite(liam);

            //var cathy = new Person("Cathy", "French");
            //var nish = new Hunter("Nish", "Mandal", "Pentax");

            //var nishPerson = (Person)nish;
            //var cathyHunter = (Hunter)cathy;

            //SpartaWrite(nish);
            //Console.WriteLine();
            //SpartaWrite(cathy);

            //var safariObject = new List<IMoveable>()
            //{
            //    new Person("Michael", "Willcock"),
            //    new Person("Uzair", "Khan"),
            //    new Person("Hossain", "Ghazal")
            //};

            //safariObject.ForEach(x => Console.WriteLine(x.Move()));

            var weaponObj = new List<IShootable>()
            {
                new Hunter("Nish", "Mandal", new Camera("Pentax")),
                new Hunter("Nish", "Mandal", new WaterPistol("Supersoaker")),
                new Hunter("Nish", "Mandal", new LaserGun("Acme")),
                new Hunter("Nish", "Mandal", new WaterPistol("Supersoaker"))

            };

            weaponObj.ForEach(x => Console.WriteLine(x.Shoot()));
        }

        static void DemoMethod(Point3d pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
        static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj.ToString());

            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot());
            }
        }
    }
}
