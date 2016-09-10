using System;
using System.Diagnostics;
using PclLocalizer.Benchmark.Loc;
using PclLocalizer.ResMan;

namespace PclLocalizer.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            PclResMan.SetLanguage("it-IT");

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                var hi = Resource1.SayHello;
                Console.WriteLine("{0}{1}", hi, i);
            }

            stopWatch.Stop();

            var stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            for (int i = 0; i < 100000; i++)
            {
                var hi = LocRes.SayHello;
                Console.WriteLine("{0}{1}", hi, i);
            }
            stopWatch2.Stop();
            Console.WriteLine($"Resx time: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"PclLocalizer time: {stopWatch2.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
