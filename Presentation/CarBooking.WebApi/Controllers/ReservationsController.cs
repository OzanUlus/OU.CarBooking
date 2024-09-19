using CarBooking.Application.Features.CQRS.Commands.ReservationCommand;
using CarBooking.Application.Features.CQRS.Queries.ReservationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReservation()
        {
            var result = await _mediator.Send(new GetAllReservationsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{reservationId}")]
        public async Task<IActionResult> GetReservation(int reservationId)
        {
            var result = await _mediator.Send(new GetReservationQueryRequest(reservationId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }


        [HttpDelete("{reservationId}")]
        public async Task<IActionResult> DeleteReservation(int reservationId)
        {
            var result = await _mediator.Send(new DeleteReservationCommandRequest(reservationId));
            return Ok(result);
        }
    }
}
