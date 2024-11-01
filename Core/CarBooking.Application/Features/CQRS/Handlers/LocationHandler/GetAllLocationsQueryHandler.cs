﻿using AutoMapper;
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
    public class GetAllLocationsQueryHandler : IRequestHandler<GetAllLocationsQueryRequest, IResponse<List<ResultLocationDto>>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public GetAllLocationsQueryHandler(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultLocationDto>>> Handle(GetAllLocationsQueryRequest request, CancellationToken cancellationToken)
        {
            var location = await _locationRepository.GetAllAsync();
            if (location == null) return new Response<List<ResultLocationDto>>(false,"Locations are not found",default);
            var locationDto = _mapper.Map<List<ResultLocationDto>>(location);
            return new Response<List<ResultLocationDto>>(true,"Locations are listed Successfully",locationDto);
        }
    }
}
