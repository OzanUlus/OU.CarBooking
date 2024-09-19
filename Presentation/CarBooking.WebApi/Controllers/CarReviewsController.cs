using CarBooking.Application.Features.CQRS.Commands.CarReviewComponent;
using CarBooking.Application.Features.CQRS.Queries.CarReviewQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarReviews()
        {
            var result = await _mediator.Send(new GetAllCarReviewsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{carReviewsId}")]
        public async Task<IActionResult> GetCarReviews(int carReviewsId)
        {
            var result = await _mediator.Send(new GetCarReviewQueryRequest(carReviewsId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarReviews(CreateCarReviewCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

       

        [HttpDelete("{carReviewsId}")]
        public async Task<IActionResult> DeleteCarReviews(int carReviewsId)
        {
            var result = await _mediator.Send(new DeleteCarReviewCommandRequest(carReviewsId));
            return Ok(result);
        }
    }
}
