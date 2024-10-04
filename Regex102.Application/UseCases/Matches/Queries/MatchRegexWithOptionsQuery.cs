using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Application.UseCases.Matches.Queries
{
    public class MatchRegexWithOptionsQuery : IRequest<bool>
    {
        public string Input { get; set; }
        public string Pattern { get; set; }
        public string[] Options { get; set; }
    }
}
