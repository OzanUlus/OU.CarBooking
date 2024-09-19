using AutoMapper;
using CarBooking.Application.Dtos.ReservationDtos;
using CarBooking.Application.Features.CQRS.Queries.ReservationQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.ReservationHandlers
{
    public class GetAllReservationsQueryHandler : IRequestHandler<GetAllReservationsQueryRequest, IResponse<List<ResultReservationDto>>>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public GetAllReservationsQueryHandler(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultReservationDto>>> Handle(GetAllReservationsQueryRequest request, CancellationToken cancellationToken)
        {
            var reservations = await _reservationRepository.GetAllAsync();
            var reservationsDto = _mapper.Map<List<ResultReservationDto>>(reservations);
            return new Response<List<ResultReservationDto>>(true,"Reservations are listed successfully",reservationsDto);
        }
    }
}
