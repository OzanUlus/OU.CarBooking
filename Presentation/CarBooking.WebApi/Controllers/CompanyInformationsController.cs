using CarBooking.Application.Features.CQRS.Commands.CompanyInformationCommand;
using CarBooking.Application.Features.CQRS.Queries.CompanyInformationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInformationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyInformationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanyInformatıon()
        {
            var result = await _mediator.Send(new GetAllCompanyInformationsQueryRequest());
            return Ok(result);
        }

        

        [HttpPost]
        public async Task<IActionResult> CreateCompanyInformatıon(CreateCompanyInformationCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

        [HttpPut("{companyInformatıonId}")]
        public async Task<IActionResult> UpdateCompanyInformatıon(UpdateCompanyInformationCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{companyInformatıonId}")]
        public async Task<IActionResult> DeleteCompanyInformatıon(int companyInformatıonId)
        {
            var result = await _mediator.Send(new DeleteCompanyInformationCommandRequest(companyInformatıonId));
            return Ok(result);
        }
    }
}
