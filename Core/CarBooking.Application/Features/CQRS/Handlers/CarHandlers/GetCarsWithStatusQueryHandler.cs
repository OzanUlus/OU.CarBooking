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
    public class GetCarsWithStatusQueryHandler : IRequestHandler<GetCarsWithStatusQueryRequest, IResponse<List<ResultCarDto>>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarsWithStatusQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultCarDto>>> Handle(GetCarsWithStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var cars = await _carRepository.GetCarsByWithStatus();
            if (cars == null) return new Response<List<ResultCarDto>>(false,"Not found avaliable car",default);
            var dto = _mapper.Map<List<ResultCarDto>>(cars);
            return new Response<List<ResultCarDto>>(true,"successfully",dto);
        }
    }
}
