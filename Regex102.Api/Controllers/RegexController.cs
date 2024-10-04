using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Regex102.Application.UseCases.Matches.Queries;
using Regex102.Application.UseCases.Substitutions.Queries;

namespace Regex102.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegexController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<RegexController> _logger;

        public RegexController(IMediator mediator, ILogger<RegexController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("Substitute")]
        public async Task <ActionResult<string>> SubstituteRegex([FromBody] SubstituteRegexQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("Match")]
        public async Task<ActionResult<bool>> MatchRegex([FromBody] MatchRegexQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("MatchWithOptions")]
        public async Task<ActionResult<bool>> MatchRegexWithOptions([FromBody] MatchRegexWithOptionsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
