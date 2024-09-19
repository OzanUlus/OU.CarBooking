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
    public class GetAllPaymentsQueryRequest : IRequest<IResponse<List<ResultPaymentDto>>>
    {
    }
}
