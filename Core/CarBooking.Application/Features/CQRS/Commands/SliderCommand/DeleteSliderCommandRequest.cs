using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.SliderCommand
{
    public class DeleteSliderCommandRequest : IRequest<IResponse<Slider>>
    {
        public int SliderId { get; set; }

        public DeleteSliderCommandRequest(int sliderId)
        {
            SliderId = sliderId;
        }
    }
}
