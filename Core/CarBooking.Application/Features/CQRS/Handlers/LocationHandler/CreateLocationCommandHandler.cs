using CarBooking.Application.Features.CQRS.Commands.LocationCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.LocationHandler
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommandRequest, IResponse<Location>>
    {
        private readonly ILocationRepository _locationRepository;

        public CreateLocationCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IResponse<Location>> Handle(CreateLocationCommandRequest request, CancellationToken cancellationToken)
        {
           
            var location = new Location
            {
                Address = request.Address,
                City = request.City,
                ContactNumber = request.ContactNumber,
            };

            await _locationRepository.CreateAsync(location);
            return new Response<Location>(true,"Location is created successfully",location);
        }
    }
}
