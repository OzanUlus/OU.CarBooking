using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.LocationCommand
{
    public class DeleteLocationCommandRequest : IRequest<IResponse<Location>>
    {
        public int LocationId { get; set; }

        public DeleteLocationCommandRequest(int locationId)
        {
            LocationId = locationId;
        }
    }
}
