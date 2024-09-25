using CarBooking.Application.Features.CQRS.Commands.SliderCommand;
using CarBooking.Application.Features.CQRS.Queries.SliderQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SlidersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSlider()
        {
            var result = await _mediator.Send(new GetSliderQueryRequest());
            return Ok(result);
        }

        

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

        

        [HttpDelete("{SliderId}")]
        public async Task<IActionResult> DeleteSlider(int SliderId)
        {
            var result = await _mediator.Send(new DeleteSliderCommandRequest(SliderId));
            return Ok(result);
        }
    }
}
