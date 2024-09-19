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
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQueryRequest, IResponse<ResultReservationDto>>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public GetReservationQueryHandler(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultReservationDto>> Handle(GetReservationQueryRequest request, CancellationToken cancellationToken)
        {
            var reservation = await _reservationRepository.GetByIdAsync(request.ReservationId);
            var reservationDto = _mapper.Map<ResultReservationDto>(reservation);
            return new Response<ResultReservationDto>(true,"Reservation is listed successfully",reservationDto);
        }
    }
}
