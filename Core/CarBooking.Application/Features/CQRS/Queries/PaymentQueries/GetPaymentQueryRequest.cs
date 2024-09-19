using CarBooking.Application.Dtos.PaymentDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.PaymentQueries
{
    public class GetPaymentQueryRequest : IRequest<IResponse<ResultPaymentDto>>
    {
        public int PaymentId { get; set; }

        public GetPaymentQueryRequest(int paymentId)
        {
            PaymentId = paymentId;
        }
    }
}
