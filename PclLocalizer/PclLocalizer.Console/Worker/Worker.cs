using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PclLocalizer.Console.Properties;

namespace PclLocalizer.Console.Worker
{
    internal class Worker
    {
        private readonly IEnumerable<string> _args;
        private readonly Checker _checker;
        private ParameterExtractor _extractor;

        public Worker(string[] args)
        {
            this._args = args;
            this._checker = new Checker(args);
            this._extractor = new ParameterExtractor(args);
        }

        public void Run()
        {
            //Help mode
            if (this._checker.IsHelpRequest)
            {
                this.RunHelp();
                return;
            }

            //Run check
            this._checker.CheckArgs();

            this.RunLocalizer();
        }

        private void RunLocalizer()
        {
            var input = this._extractor.InputFile;
            var destination = this._extractor.DestinationFile;
            var separator = this._extractor.Separator;
            var nameSpace = this._extractor.NameSpace;

            var magic = Resources.MagicFile;// File.ReadAllText("File/MagicFile.txt");

            //Add destination name
            magic = magic.Replace(Constants.DestinationPlaceHolder, destination);
            //Add namespace
            magic = magic.Replace(Constants.NamespacePlaceHolder, nameSpace);

            //Check file
            var lines = File.ReadAllLines(input);
            var firstLine = lines[0].Split(new[] { separator }, StringSplitOptions.None).ToList();
            var languages = new List<string>();

            for (int i = 1; i < firstLine.Count; i++)
            {
                languages.Add(firstLine[i]);
                System.Console.WriteLine($"Language {firstLine[i]} found.");
            }

            //Create Dictionary
            var dictionarySection = new StringBuilder();
            var dictionaryCounter = 0;
            foreach (var language in languages)
            {
                dictionaryCounter++;
                var varname = $"d{dictionaryCounter}";

                dictionarySection.Append($"\t\t\tvar {varname} = new Dictionary<string, string> {{");
                
                var langIndex = firstLine.IndexOf(language);
                for (int index = 0; index < lines.Length; index++)
                {
                    if(index == 0)continue;
                    var splitted = lines[index].Split(new[] { separator }, StringSplitOptions.None);
                    var key = splitted[0];
                    var value = splitted[langIndex];

                    dictionarySection.Append($"{{\"{key}\",\"{value}\"}},");
                }
                dictionarySection.Remove(dictionarySection.Length - 1, 1);
                dictionarySection.Append($"}};{Environment.NewLine}");
                dictionarySection.Append($"\t\t\tvalues.Add(\"{language}\", {varname});{Environment.NewLine}");
            }

            magic = magic.Replace(Constants.DictionariesPlaceHolder, dictionarySection.ToString());

            //Properties
            var propertiesSection = new StringBuilder();

            for (int index = 0; index < lines.Length; index++)
            {
                if (index == 0) continue;
                var splitted = lines[index].Split(new[] { separator }, StringSplitOptions.None);
                var key = splitted[0];

                propertiesSection.AppendLine($"\t\tpublic static string {key} => GetValue(\"{key}\");");
            }

            magic = magic.Replace(Constants.PropertiesPlaceHolder, propertiesSection.ToString());

            File.WriteAllText($"{destination}.cs",magic);

            System.Console.WriteLine("All done!");
        }

        private void RunHelp()
        {
            System.Console.WriteLine("Welcome to PclLocalizer!");
            System.Console.WriteLine("*** A big thanks to Mark Jack Milian for having created me! ***");
            System.Console.WriteLine("I need those args:");
            System.Console.WriteLine("-f INPUTFILE => the input file with a separator");
            System.Console.WriteLine("-s SEPARATOR => the separator for input file");
            System.Console.WriteLine("-d DESTINATIONCLASSNAME => the destination classname/file");
            System.Console.WriteLine("-n NAMESPACE => the namespace for generated class");
            System.Console.WriteLine("The first line of input file must be:");
            System.Console.WriteLine("Column[0]: key");
            System.Console.WriteLine("Column[X]: languageCode");
            System.Console.WriteLine("");
            System.Console.WriteLine("Have Fun!");
        }
    }
}
