using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Substitutions.Queries
{
    public class SubstituteRegexQuery : IRequest<string>
    {
        public required string Input { get; set; }
        public required string Pattern { get; set; }
        public required string Replacement { get; set; }
    }
}
