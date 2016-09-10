using System.Collections.Generic;
using System.IO;
using System.Linq;
using PclLocalizer.Console.Exceptions;

namespace PclLocalizer.Console
{
    class Checker
    {
        private readonly IList<string> _arguments;

        public Checker(IEnumerable<string> arguments)
        {
            this._arguments = arguments.ToList();
        }


        public void CheckArgs()
        {
            if (this.NoArguments)
                throw new ParameterMissingException("I need some parameter! Try -h");

            if (!this.InputFileArgumentExist)
                throw new FileNotFoundException("Input file not exist! -f");

            if (!this.DestFileArgumentsExist)
                throw new ParameterMissingException("I need destination class name parameter! -d");

            if (!this.SeparatorArgumentsExist)
                throw new ParameterMissingException("I need separator for input file! -s");

            if (!this.NamespaceArgumentsExist)
                throw new ParameterMissingException("I need namespace for input file! -n");
        }

        /// <summary>
        /// Is help request
        /// </summary>
        public bool IsHelpRequest => this._arguments.Contains("-h");

        /// <summary>
        /// There are no arguments
        /// </summary>
        public bool NoArguments => !this._arguments.Any();

        /// <summary>
        /// Check if input file exist
        /// </summary>
        public bool InputFileArgumentExist
        {
            get
            {
                if (!this._arguments.Contains(Constants.InputParam)) return false;

                var index = this._arguments.IndexOf(Constants.InputParam);
                if (index >= this._arguments.Count - 1) return false;

                return File.Exists(this._arguments[index + 1]);
            }
        }

        /// <summary>
        /// Exist arguments -d and is passed
        /// </summary>
        public bool DestFileArgumentsExist
        {
            get
            {
                var paramexist = this._arguments.Contains(Constants.DestinationParam);

                if (!paramexist) return false;

                var index = this._arguments.IndexOf(Constants.DestinationParam);
                if (index >= this._arguments.Count - 1) return false;

                return true;
            }
        }

        /// <summary>
        /// Exist arguments -s and is passed
        /// </summary>
        public bool SeparatorArgumentsExist
        {
            get
            {
                var paramexist = this._arguments.Contains(Constants.SeparatorParam);

                if (!paramexist) return false;

                var index = this._arguments.IndexOf(Constants.SeparatorParam);
                if (index >= this._arguments.Count - 1) return false;

                return true;
            }
        }

        /// <summary>
        /// Exist arguments -n and is passed
        /// </summary>
        public bool NamespaceArgumentsExist
        {
            get
            {
                var paramexist = this._arguments.Contains(Constants.NamespaceParam);

                if (!paramexist) return false;

                var index = this._arguments.IndexOf(Constants.NamespaceParam);
                if (index >= this._arguments.Count - 1) return false;

                return true;
            }
        }

    }
}
