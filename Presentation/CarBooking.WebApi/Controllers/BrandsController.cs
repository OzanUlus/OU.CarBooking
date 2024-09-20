using CarBooking.Application.Features.CQRS.Commands.BrandCommands;
using CarBooking.Application.Features.CQRS.Queries.BrandQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrand() 
        {
            var result = await _mediator.Send(new GetAllBrandQueryRequest());
            return Ok(result);
        }

        [HttpGet("{brandId}")]
        public async Task<IActionResult> GetBrand(int brandId)
        {
            var result = await _mediator.Send(new GetBrandQueryRequest(brandId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("" ,result);
        }

        [HttpPut("{brandId}")]
        public async Task<IActionResult> UpdateBrand([FromRoute] int brandId,UpdateBrandCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{brandId}")]
        public async Task<IActionResult> DeleteBrand(int brandId)
        {
            var result = await _mediator.Send(new DeleteBrandCommandRequest(brandId));
            return Ok(result);
        }
    }
}
