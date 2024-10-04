using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Domain.Contracts.Substutution
{
    public interface ISubstuteRegex
    {
        string Replace(string input, string pattern, string replacement);
    }
}
