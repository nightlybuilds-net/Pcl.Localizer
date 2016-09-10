using System.Collections.Generic;
using System.Linq;

namespace PclLocalizer.Console
{
    class ParameterExtractor
    {
        private readonly IList<string> _arguments;

        public ParameterExtractor(IEnumerable<string> arguments )
        {
            this._arguments = arguments.ToList();
        }


        public string InputFile => this.GetValue(Constants.InputParam);

        public string DestinationFile => this.GetValue(Constants.DestinationParam);
        public string Separator => this.GetValue(Constants.SeparatorParam);
        public string NameSpace => this.GetValue(Constants.NamespaceParam);

        private string GetValue(string param)
        {
            var index = this._arguments.IndexOf(param);
            return this._arguments[index + 1];
        }
        
    }
}
