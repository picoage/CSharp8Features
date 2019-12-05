using System;
using System.Diagnostics;

namespace CSharp8Features
{
    class Program
    {
        static void Main(string[] args)
        {
            CallReadOnlyMember();
            Console.ReadLine();
        }

        static void CallReadOnlyMember()
        {
            Console.WriteLine("Do you want to run test");
            string value = Console.ReadLine();

            Stopwatch stopWatch = new Stopwatch();
            if (value != null && value.ToLower().Equals("yes"))
            {
                long kbAtExecution = GC.GetTotalMemory(false) / 1024;
                stopWatch.Start();
                for (Int64 i = 0; i < 2000000; i++)
                {
                    ReadOnlyMember.ReadOnlyMember rd = new ReadOnlyMember.ReadOnlyMember();
                    rd.X = 10;
                    rd.Y = 20;

                    Console.WriteLine($"Count{i}:{rd.ToString()}");
                }

                stopWatch.Stop();
                long kbAfter1 = GC.GetTotalMemory(false) / 1024;
                //long kbAfter2 = GC.GetTotalMemory(true) / 1024;
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine($"Process ended");
                Console.WriteLine(kbAtExecution + " Started with this kb.");
                Console.WriteLine(kbAfter1 + " After the test.");
                Console.WriteLine(kbAfter1 - kbAtExecution + " Total Collected by GC");
                Console.WriteLine($"Time Elapsed {elapsedTime}");
                //Console.WriteLine(kbAfter2 + " Amt. After Collection");
                //Console.WriteLine(kbAfter2 - kbAfter1 + " Amt. Collected by GC.");
            }
        }
    }
}
