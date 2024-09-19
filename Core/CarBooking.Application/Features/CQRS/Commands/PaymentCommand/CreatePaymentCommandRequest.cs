using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.PaymentCommand
{
    public class CreatePaymentCommandRequest : IRequest<IResponse<Payment>>
    {
        
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
       
    }
}
