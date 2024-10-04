using Regex102.Application.Errors;
using Regex102.Domain.Contracts.Matches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Matches
{
    public class MatchRegexWithOptions : IMatchRegexWithOptions
    {
        public bool IsMatch(string input, string pattern, RegexOptions options)
        {
            try
            {
                var regex = new Regex(pattern, options);
                return regex.IsMatch(input);
            }
            catch (RegexParseException)
            {
                throw new InvalidRegExFormatException($"Invalid regex pattern {pattern}");
            }
        }
    }
}
