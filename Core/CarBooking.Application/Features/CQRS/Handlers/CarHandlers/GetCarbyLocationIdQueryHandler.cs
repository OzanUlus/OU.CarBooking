using AutoMapper;
using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Application.Features.CQRS.Queries.CarQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarbyLocationIdQueryHandler : IRequestHandler<GetCarByLocationIdQueryRequest, IResponse<List<ResultCarDto>>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarbyLocationIdQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultCarDto>>> Handle(GetCarByLocationIdQueryRequest request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetCarByLocationId(request.LocationId);
            var dto = _mapper.Map<List<ResultCarDto>>(car);
            return new Response<List<ResultCarDto>>(true,"Successfully",dto);
        }
    }
}
