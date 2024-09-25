using CarBooking.Application.Dtos.SliderDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.SliderCommand
{
    public class CreateSliderCommandRequest : IRequest<IResponse<CreateSliderDto>>
    {
        public string ImageUrl1 { get; set; }
        public string Title1 { get; set; }
        public string Description1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string Title3 { get; set; }
        public string Description3 { get; set; }
    }
}
