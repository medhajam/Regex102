using MediatR;
using Regex102.Application.UseCases.Matches.Queries;
using Regex102.Domain.Contracts.Matches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Matches.QueriesHandlers
{
    public class MatchRegexQueryHandler : IRequestHandler<MatchRegexQuery, bool>
    {
        private readonly IMatchRegex _regexMatcher;

        public MatchRegexQueryHandler(IMatchRegex regexMatcher)
        {
            _regexMatcher = regexMatcher;
        }

        public Task<bool> Handle(MatchRegexQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_regexMatcher.IsMatch(request.Input, request.Pattern));
        }
    }
}
