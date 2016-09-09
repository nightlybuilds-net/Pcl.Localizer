using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class TestRes
    {
        private static Dictionary<string,Dictionary<string,string>> values = new Dictionary<string, Dictionary<string, string>>();

        static TestRes()
        {
            var enDic = new Dictionary<string, string> {{"saluta", "hello!"}};
            var itDic = new Dictionary<string, string> {{"saluta", "ciao!"}};

            values.Add("en", enDic);
            values.Add("it", itDic);
        }

        public static string Value1 => values[ResourceManager.Lang]["saluta"];
    }
}
