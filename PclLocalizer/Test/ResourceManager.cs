using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public static class ResourceManager
    {
        public static string Lang { get; private set; }

        public static void SetLanguage(string language)
        {
            Lang = language;
        }
    }
}
