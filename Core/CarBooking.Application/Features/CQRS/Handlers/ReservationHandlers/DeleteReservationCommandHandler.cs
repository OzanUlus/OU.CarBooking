using CarBooking.Application.Features.CQRS.Commands.ReservationCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.ReservationHandlers
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommandRequest, IResponse<Reservation>>
    {
        private readonly IReservationRepository _reservationRepository;

        public DeleteReservationCommandHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IResponse<Reservation>> Handle(DeleteReservationCommandRequest request, CancellationToken cancellationToken)
        {
            await _reservationRepository.DeleteAsync(request.ReservationId);
            return new Response<Reservation>(true,"Reservation si deleted successfully",default);
        }
    }
}
