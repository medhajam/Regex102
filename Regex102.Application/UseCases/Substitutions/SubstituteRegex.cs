using Microsoft.Extensions.Logging;
using Regex102.Application.Errors;
using Regex102.Domain.Contracts.Substutution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Substitutions
{
    public class SubstituteRegex : ISubstuteRegex
    {
        private readonly ILogger<SubstituteRegex> _logger;

        public SubstituteRegex(ILogger<SubstituteRegex> logger)
        {
            _logger = logger;
        }

        public string Replace(string input, string pattern, string replacement)
        {
            try
            {
                _logger.LogInformation($"Substituting regex pattern {pattern} with {replacement}");
                var regex = new Regex(pattern);
                return regex.Replace(input, replacement);
            }
            catch (RegexParseException)
            {
               throw new InvalidRegExFormatException($"Invalid regex pattern {pattern}");
            }
        }
    }
}
