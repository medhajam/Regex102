using MediatR;
using Regex102.Application.UseCases.Substitutions.Queries;
using Regex102.Domain.Contracts.Substutution;

namespace Regex102.Application.UseCases.Substitutions.QueriesHandlers
{
    public class SubstituteRegexQueryHandler : IRequestHandler<SubstituteRegexQuery, string>
    {
        private readonly ISubstuteRegex _regexSubstutor;

        public SubstituteRegexQueryHandler(ISubstuteRegex regexSubstutor)
        {
            _regexSubstutor = regexSubstutor;
        }

        public Task<string> Handle(SubstituteRegexQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_regexSubstutor.Replace(request.Input, request.Pattern, request.Replacement));
        }
    }
}
