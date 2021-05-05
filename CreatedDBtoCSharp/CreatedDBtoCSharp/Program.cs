using System;

namespace CreatedDBtoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Eng86Context())
            {
                foreach (var c in db.Trainees)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
