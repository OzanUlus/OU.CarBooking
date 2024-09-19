using CarBooking.Application.Dtos.ReservationDtos;
using CarBooking.Application.Response;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.ReservationQueries
{
    public class GetReservationQueryRequest : IRequest<IResponse<ResultReservationDto>>
    {
        public int ReservationId { get; set; }

        public GetReservationQueryRequest(int reservationId)
        {
            ReservationId = reservationId;
        }
    }
}
