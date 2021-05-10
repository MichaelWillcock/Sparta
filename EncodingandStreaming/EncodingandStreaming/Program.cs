using System;
using System.IO;
using System.Diagnostics;

namespace EncodingandStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console Logging
            //Console.WriteLine($"This is being logged at {DateTime.Now}");

            ////Logging - Trace and Debug Class
            //Console.WriteLine($"This is being logged at {DateTime.Now}");
            //var twt1 = new TextWriterTraceListener(File.Create("TraceOutput.txt"));
            //Trace.Listeners.Add(twt1);
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    Debug.WriteLine($"Debug - thee value of i is {i}");
            //    Trace.WriteLine($"Trace - thee value of i is {i}");
            //    Debug.WriteLineIf(i == 2, $"\nReached the max value of i: {i} at {DateTime.Now}");
            //    Trace.Assert(i > 0, $"i is not greater than 0 {i}");
            //}
            //Trace.Flush();

            //            //Conditional compiling
            //            Console.WriteLine("Starting app");
            //#if DEBUG
            //            Console.WriteLine("This is Debug Code");
            //#if TEST
            //#
            //            Console.WriteLine("Finishing App");

            //Streamwriters and readers
            string path = "Live Forever.txt";
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Live Forever");
            }
            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
