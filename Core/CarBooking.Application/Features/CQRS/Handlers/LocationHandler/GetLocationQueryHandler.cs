using AutoMapper;
using CarBooking.Application.Dtos.LocationDtos;
using CarBooking.Application.Features.CQRS.Queries.LocationQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.LocationHandler
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQueryRequest, IResponse<ResultLocationDto>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public GetLocationQueryHandler(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultLocationDto>> Handle(GetLocationQueryRequest request, CancellationToken cancellationToken)
        {
            var location = await _locationRepository.GetByIdAsync(request.LocationId);
            var locationDto = _mapper.Map<ResultLocationDto>(location);
            return new Response<ResultLocationDto>(true,"Location is found",locationDto);
        }
    }
}
