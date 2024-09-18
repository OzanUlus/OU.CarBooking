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
    public class CreateLocationCommandRequest : IRequest<IResponse<Location>>
    {
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}
