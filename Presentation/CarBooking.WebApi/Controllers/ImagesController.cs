using CarBooking.Application.Features.CQRS.Commands.ImageCommand;
using CarBooking.Application.Features.CQRS.Queries.ImageQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllImage()
        {
            var result = await _mediator.Send(new GetAllImagesQueryRequest());
            return Ok(result);
        }

        [HttpGet("{ImageId}")]
        public async Task<IActionResult> GetImage(int ImageId)
        {
            var result = await _mediator.Send(new GetImageQueryRequest(ImageId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateImage(CreateImageCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

       

        [HttpDelete("{ImageId}")]
        public async Task<IActionResult> DeleteImage(int ImageId)
        {
            var result = await _mediator.Send(new DeleteImageCommandRequest(ImageId));
            return Ok(result);
        }
    }
}
