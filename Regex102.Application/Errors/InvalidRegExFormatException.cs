using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Application.Errors
{
    public class InvalidRegExFormatException : Exception
    {
        public InvalidRegExFormatException(string message)
    : base(message)
        {
        }
    }
}
