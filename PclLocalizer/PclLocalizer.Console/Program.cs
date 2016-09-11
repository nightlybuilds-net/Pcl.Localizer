using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclLocalizer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var worker = new Worker.Worker(args);
                worker.Run();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.ReadLine();
            }
        }
    }
}
