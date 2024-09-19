using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.ReservationCommand
{
    public class DeleteReservationCommandRequest : IRequest<IResponse<Reservation>>
    {
        public int ReservationId { get; set; }

        public DeleteReservationCommandRequest(int reservationId)
        {
            ReservationId = reservationId;
        }
    }
}
