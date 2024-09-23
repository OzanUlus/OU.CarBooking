using CarBooking.Application.Features.CQRS.Commands.CarCommand;
using CarBooking.Application.Features.CQRS.Queries.CarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCar()
        {
            var result = await _mediator.Send(new GetAllCarsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{CarId}")]
        public async Task<IActionResult> GetCar(int CarId)
        {
            var result = await _mediator.Send(new GetCarQueryRequest(CarId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

        [HttpPut("{carId}")]
        public async Task<IActionResult> UpdateCar(UpdateCarCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{CarId}")]
        public async Task<IActionResult> DeleteCar(int CarId)
        {
            var result = await _mediator.Send(new DeleteCarCommandRequest(CarId));
            return Ok(result);
        }
    }
}
