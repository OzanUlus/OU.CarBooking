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
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommandRequest, IResponse<Location>>
    {
        private readonly ILocationRepository _locationRepository;

        public UpdateLocationCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IResponse<Location>> Handle(UpdateLocationCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedLocation = await _locationRepository.GetByIdAsync(request.LocationId);
            if (updatedLocation != null)
            {
                updatedLocation.ContactNumber = request.ContactNumber;
                updatedLocation.Address = request.Address;
                updatedLocation.City = request.City;
                return new Response<Location>(true,"Location is updated successfully",default);
            }
            return new Response<Location>(false, "Location is not found", default);
        }
    }
}
