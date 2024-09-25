using CarBooking.Application.Features.CQRS.Commands.SliderCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.SliderHandler
{
    public class DeleteSliderCommandHandler : IRequestHandler<DeleteSliderCommandRequest, IResponse<Slider>>
    {
        private readonly ISliderRepository _sliderRepository;

        public DeleteSliderCommandHandler(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }

        public async Task<IResponse<Slider>> Handle(DeleteSliderCommandRequest request, CancellationToken cancellationToken)
        {
            await _sliderRepository.DeleteAsync(request.SliderId);
            return new Response<Slider>(true,"Slider deleted successfully",default);
        }
    }
}
