using CarBooking.Application.Features.CQRS.Commands.LocationCommand;
using CarBooking.Application.Features.CQRS.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLocation()
        {
            var result = await _mediator.Send(new GetAllLocationsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{LocationId}")]
        public async Task<IActionResult> GetLocation(int LocationId)
        {
            var result = await _mediator.Send(new GetLocationQueryRequest(LocationId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{LocationId}")]
        public async Task<IActionResult> DeleteLocation(int LocationId)
        {
            var result = await _mediator.Send(new DeleteLocationCommandRequest(LocationId));
            return Ok(result);
        }
    }
}
