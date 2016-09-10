using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceManager.SetLanguage("en");

            //System.Console.WriteLine(TestRes.Value1);
            //System.Console.ReadLine();

            //ResourceManager.SetLanguage("it");

            //System.Console.WriteLine(TestRes.Value1);
            //System.Console.ReadLine();


            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 10000; i++)
            {
                var t  = Resource1.A;
                //var t = TestRes.Value1;
                System.Console.WriteLine(t);
            }

            stopWatch.Stop();

            System.Console.WriteLine(stopWatch.ElapsedMilliseconds);

            System.Console.Read();

        }
    }
}
