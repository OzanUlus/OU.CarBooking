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
    public class GetCarQueryHandler : IRequestHandler<GetCarQueryRequest, IResponse<ResultCarDto>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultCarDto>> Handle(GetCarQueryRequest request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetByIdAsync(request.CarId);
            if (car != null) 
            {
                var carDto = _mapper.Map<ResultCarDto>(car);
                return new Response<ResultCarDto>(true, "successfully", carDto);
            }
            return new Response<ResultCarDto>(false, "Car is not found", default);

        }
    }
}
