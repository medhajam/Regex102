using Regex102.Application.Errors;
using Regex102.Domain.Contracts.Matches;
using System.Text.RegularExpressions;

namespace Regex102.Application.UseCases.Matches
{
    public class MatchRegex : IRegexMatcher
    {
        public bool IsMatch(string input, string pattern)
        {
            try
            {
                var regex = new Regex(pattern);
                return regex.IsMatch(input);
            }
            catch (RegexParseException ex)
            {
                throw new InvalidRegExFormatException($"Invalid regex pattern {pattern}");              
            }
        }
    }
}
