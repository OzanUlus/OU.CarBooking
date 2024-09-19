using AutoMapper;
using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Application.Features.CQRS.Queries.CarQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQueryRequest, IResponse<List<ResultCarDto>>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetAllCarsQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultCarDto>>> Handle(GetAllCarsQueryRequest request, CancellationToken cancellationToken)
        {
            var cars = await _carRepository.GetAllAsync();
            if (cars == null) return new Response<List<ResultCarDto>>(false,"Cars are not found",default);
            var dto = _mapper.Map<List<ResultCarDto>>(cars);
            return new Response<List<ResultCarDto>>(true,"Cars is listed successfully",dto);
        }
    }
}
