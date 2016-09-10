using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PclLocalizer.ResMan;

namespace NugetTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var current = CultureInfo.CurrentCulture.ToString();

            PclResMan.SetLanguage(current);

            System.Console.WriteLine($"Current is: {current}");
            System.Console.WriteLine($"Ciao is: {TestLoc.Common_IdealWeight}");

            System.Console.ReadLine();

            System.Console.WriteLine("Force to en");

            PclResMan.SetLanguage("en");

            System.Console.WriteLine($"Ciao is: {TestLoc.Generic_WantStartNewExam}");

            System.Console.ReadLine();

            

        }
    }
}
