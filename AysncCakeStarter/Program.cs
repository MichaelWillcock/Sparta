using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            HaveAParty();
            Console.WriteLine("Thanks for a lovely party");
            Console.ReadLine();
        }

        private static void HaveAParty()
        {
            var name = "Cathy";
            var castletask = SetUpABouncyCastleAsync();
            var caketask = BakeCakeAsync();
            PlayPartyGames();
            OpenPresents();
            var cake = caketask.Result;
            var castle = castletask.Result;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
            Console.WriteLine(castle);
        }

        private static async Task<BouncyCastle>  SetUpABouncyCastleAsync()
        {
            Console.WriteLine("Blow up the bouncy castle");
            await Task.Delay(TimeSpan.FromSeconds(4));
            Console.WriteLine("Get off bouncy castle before cake");
            return new BouncyCastle();
        }

        private static async Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Cake is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }
    public class BouncyCastle
    {
        public override string ToString()
        {
            return "take down bouncy castle";
        }
    }
}
