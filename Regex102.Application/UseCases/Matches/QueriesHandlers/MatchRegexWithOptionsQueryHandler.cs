using MediatR;
using Regex102.Application.UseCases.Matches.Queries;
using Regex102.Domain.Contracts.Matches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Matches.QueriesHandlers
{
    public class MatchRegexWithOptionsQueryHandler : IRequestHandler<MatchRegexWithOptionsQuery, bool>
    {
        private readonly IMatchRegexWithOptions _regexMatcherWithOptions;

        public MatchRegexWithOptionsQueryHandler(IMatchRegexWithOptions regexMatcher)
        {
            _regexMatcherWithOptions = regexMatcher;
        }

        public Task<bool> Handle(MatchRegexWithOptionsQuery request, CancellationToken cancellationToken)
        {
            var options = ParseOptions(request.Options);
            return Task.FromResult(_regexMatcherWithOptions.IsMatch(request.Input, request.Pattern, options));
        }

        private RegexOptions ParseOptions(string[] options)
        {
            RegexOptions result = RegexOptions.None;
            foreach (var option in options)
            {
                if (Enum.TryParse(option, out RegexOptions parsedOption))
                {
                    result |= parsedOption;
                }
            }
            return result;
        }
    }
}
