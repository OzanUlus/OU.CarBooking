using CarBooking.Application.Dtos.AboutDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.AboutCommand
{
    public class CreateAboutCommandRequest : IRequest<IResponse<CreateAboutDto>>
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
