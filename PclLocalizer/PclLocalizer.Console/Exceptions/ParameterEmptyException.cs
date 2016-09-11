using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclLocalizer.Console.Exceptions
{
    class ParameterEmptyException : Exception
    {
        public ParameterEmptyException(string msg) : base(msg)
        {}
    }
}
