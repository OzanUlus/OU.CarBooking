using CarBooking.Application.Features.CQRS.Commands.AboutCommand;
using CarBooking.Application.Features.CQRS.Queries.AboutQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAbout()
        {
            var result = await _mediator.Send(new GetAllAboutsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{aboutId}")]
        public async Task<IActionResult> GetAbout(int aboutId)
        {
            var result = await _mediator.Send(new GetAboutQueryRequest(aboutId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

        [HttpPut("{aboutId}")]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{aboutId}")]
        public async Task<IActionResult> DeleteAbout(int aboutId)
        {
            var result = await _mediator.Send(new DeleteAboutCommandRequest(aboutId));
            return Ok(result);
        }
    }
}
