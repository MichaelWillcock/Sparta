using System;

namespace CodeFromNorthwind
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                Console.WriteLine(db.ContextId);
            }
        }
    }
}
