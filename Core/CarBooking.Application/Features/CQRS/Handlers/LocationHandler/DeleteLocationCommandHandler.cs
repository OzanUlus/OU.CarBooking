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
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommandRequest, IResponse<Location>>
    {
        private readonly ILocationRepository _locationRepository;

        public DeleteLocationCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IResponse<Location>> Handle(DeleteLocationCommandRequest request, CancellationToken cancellationToken)
        {
            await _locationRepository.DeleteAsync(request.LocationId);
            return new Response<Location>(true,"Location is deleted successfully",default);
        }
    }
}
