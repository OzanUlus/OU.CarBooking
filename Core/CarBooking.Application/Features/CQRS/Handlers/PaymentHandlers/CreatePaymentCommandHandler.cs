using CarBooking.Application.Features.CQRS.Commands.PaymentCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.PaymentHandlers
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommandRequest, IResponse<Payment>>
    {
        private readonly IPaymentRepository _paymentRepository;

        public CreatePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IResponse<Payment>> Handle(CreatePaymentCommandRequest request, CancellationToken cancellationToken)
        {
            await _paymentRepository.CreateAsync(new Payment 
            {
                Amount = request.Amount,
                UserId = request.UserId,
                ReservationId = request.ReservationId,
                PaymentDate = DateTime.Now,

            });
            return new Response<Payment>(true,"Payment is created successfully",default);
        }
    }
}
