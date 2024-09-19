using CarBooking.Application.Features.CQRS.Commands.ReservationCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using CarBooking.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommandRequest, IResponse<Reservation>>
    {
        private readonly IReservationRepository _reservationRepository;

        public CreateReservationCommandHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IResponse<Reservation>> Handle(CreateReservationCommandRequest request, CancellationToken cancellationToken)
        {
            await _reservationRepository.CreateAsync(new Reservation
            {
                CarId = request.CarId,
                UserId = request.UserId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TotalPrice = request.TotalPrice,
                ReservationStatus = ReservationStatus.Pending,
                CreatedDate = DateTime.Now,

            });
            return new Response<Reservation>(true, "Reservation is created successfully", default);
        }
    }
}
