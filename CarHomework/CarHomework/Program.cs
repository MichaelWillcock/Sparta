using System;

namespace CarHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Console.WriteLine(v.Position);
            Console.WriteLine(result);
        }
    }
}
