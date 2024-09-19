using CarBooking.Application.Dtos.ReservationDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.ReservationQueries
{
    public class GetAllReservationsQueryRequest : IRequest<IResponse<List<ResultReservationDto>>>
    {
    }
}
