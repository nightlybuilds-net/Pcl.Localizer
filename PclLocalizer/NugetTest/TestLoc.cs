using System.Collections.Generic;
using System.Linq;
using PclLocalizer.ResMan;

namespace NugetTest
{
    public static class TestLoc
    {
        private static Dictionary<string,Dictionary<string,string>> values = new Dictionary<string, Dictionary<string, string>>();

        static TestLoc()
        {
			var d1 = new Dictionary<string, string> {{"SayHello","Ciao!"},{"Play","Giocare"}};
			values.Add("it-IT", d1);
			var d2 = new Dictionary<string, string> {{"SayHello","Hello!"},{"Play","Play"}};
			values.Add("en", d2);
            
        }

			public static string SayHello => GetValue("SayHello");
			public static string Play => GetValue("Play");


		private static string GetValue(string key)
        {
            if (values.ContainsKey(PclResMan.Lang))
                return values[PclResMan.Lang][key];
            else
            {
                return PclResMan.Default == null ? values[values.First().Key][key] : values[PclResMan.Default][key];
            }
        }
    }
}