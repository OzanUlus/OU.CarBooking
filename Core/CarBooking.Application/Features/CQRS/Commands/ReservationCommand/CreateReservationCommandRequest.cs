using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using CarBooking.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.ReservationCommand
{
    public class CreateReservationCommandRequest : IRequest<IResponse<Reservation>>
    {
       
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
    }
}
