using System.Collections.Generic;
using Test;

namespace Eddai
{
    public static class LocTest
    {
        private static Dictionary<string, Dictionary<string, string>> values = new Dictionary<string, Dictionary<string, string>>();

        static LocTest()
        {
            var d1 = new Dictionary<string, string> { { "SayHello", "SayHello" }, { "Play", "Play" } };
            values.Add("it", d1);
            var d2 = new Dictionary<string, string> { { "SayHello", "Ciao!" }, { "Play", "Giocare" } };
            values.Add("en", d2);

        }

        public static string SayHello => values[ResourceManager.Lang]["SayHello"];
        public static string Play => values[ResourceManager.Lang]["Play"];

    }
}