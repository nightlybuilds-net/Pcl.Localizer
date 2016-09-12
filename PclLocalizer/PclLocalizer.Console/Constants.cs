using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclLocalizer.Console
{
    static class Constants
    {
        public static string InputParam => "-f";
        public static string DestinationParam => "-d";
        public static string SeparatorParam => "-s";
        public static string NamespaceParam => "-n";
        public static string ClassNameParam => "-c";

        public static string NamespacePlaceHolder => "{{namespace}}";
        public static string PropertiesPlaceHolder => "{{properties}}";
        public static string DictionariesPlaceHolder => "{{dictionaries}}";
        public static string ClassNamePlaceHolder => "{{classname}}";



    }
}
