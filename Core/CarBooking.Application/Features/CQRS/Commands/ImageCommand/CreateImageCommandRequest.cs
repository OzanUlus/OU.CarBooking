using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.ImageCommand
{
    public class CreateImageCommandRequest : IRequest<IResponse<Image>>
    {
        public int CarId { get; set; }
        public string ImageUrl { get; set; }
    }
}
