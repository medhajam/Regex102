using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Matches.Queries
{
    public class MatchRegexQuery : IRequest<bool>
    {
        public required string Input { get; set; }
        public required string Pattern { get; set; }
    }
}
