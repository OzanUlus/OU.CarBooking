using CarBooking.Application.Features.CQRS.Commands.PaymentCommand;
using CarBooking.Application.Features.CQRS.Queries.PaymentQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPayment()
        {
            var result = await _mediator.Send(new GetAllPaymentsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{paymentId}")]
        public async Task<IActionResult> GetPayment(int paymentId)
        {
            var result = await _mediator.Send(new GetPaymentQueryRequest(paymentId));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment(CreatePaymentCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("", result);
        }

      
    }
}
