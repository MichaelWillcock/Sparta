using System;
using System.Collections.Generic;

namespace Lab_08_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ARRAYLISTS
            //ArrayList myAL = new ArrayList();
            //myAL.Add("Hello");
            //myAL.Add(1);
            //myAL.Add('c');

            //foreach(var item in myAL)
            //{
            //    Console.WriteLine(item);
            //}
            // boxed into an object and then when we want to use it we unbox it
            //no longer used. Isn't included in System.Collections.Generic only used in
            //System.Collections


            ////LISTS
            //List<int> nums = new List<int>();
            //List<int> morenums = new List<int> { 1, 4, 3, 7, 0 };

            //var x = morenums[0];

            //morenums.Remove(1);
            //morenums.ForEach(x => Console.WriteLine(x));
            //var average = morenums.Average();
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //numbers.ForEach(x => Console.WriteLine(x));
            //numbers.Add(6);
            //numbers.Add(7);
            //numbers.Add(8);
            //numbers.Insert(2, 4);
            //numbers.Reverse();
            //numbers.RemoveAt(3);
            //numbers.ForEach(x => Console.WriteLine(x));
            //numbers.Sort();
            //numbers.ForEach(x => Console.WriteLine(x));

            ////QUEUE
            //var myQueue = new Queue<string>();
            //myQueue.Enqueue("Nish");
            //myQueue.Enqueue("Jack");

            //Console.WriteLine(myQueue.Peek());
            //Console.WriteLine(myQueue.Contains("Jack"));
            //Console.WriteLine(myQueue.Dequeue());

            //foreach(var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            ////STACKS
            //var myStack = new Stack<string>();
            //myStack.Push("Blue");
            //myStack.Push("Green");
            //myStack.Push("Yellow");
            //myStack.Push("Red");

            //Console.WriteLine(myStack.Pop()); //removes item at index zero and shifts the rest along 1

            ////HASHSETS

            //var Eng86 = new List<string> { "Rouzbeh", "Callum", "Hamse", "Eric", "Callum" };

            //Eng86.ForEach(x => Console.WriteLine(x));

            //var hSet = new HashSet<string>(Eng86);
            //Console.WriteLine();
            //foreach (var item in hSet)
            //{
            //    Console.WriteLine(item);
            //}

            ////DICTIONARIES
            //Dictionary<int, string> trainers = new Dictionary<int, string>();
            //trainers.Add(1, "Cathy");
            //trainers.Add(2, "David");
            //trainers.Add(3, "Paula");
            //trainers.TryAdd(3, "Manish");

            //var trainees = new Dictionary<int, string> { { 1, "Bongani" }, { 2, "Uzair" } };
            //var trainees2 = new Dictionary<int, string> { [1] = "Bongani", [2] = "Uzair" };

            //foreach (var item in trainees)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value + " " + item);
            //}

            //string input = "Hello World";
            //input = input.Trim().ToLower();

            //var count = new Dictionary<char, int>();

            //foreach (var c in input)
            //{
            //    if (count.ContainsKey(c))
            //    {
            //        count[c]++;
            //    }
            //    else
            //    {
            //        count.Add(c, 1);
            //    }
            //}
            //foreach (var item in count)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
