using AutoMapper;
using CarBooking.Application.Dtos.SliderDtos;
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
    public class CreateSliderCommandHandler : IRequestHandler<CreateSliderCommandRequest, IResponse<CreateSliderDto>>
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;

        public CreateSliderCommandHandler(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<CreateSliderDto>> Handle(CreateSliderCommandRequest request, CancellationToken cancellationToken)
        {
            var slider = new Slider { 
             Description1 = request.Description1,
             Description2 = request.Description2,
             Description3 = request.Description3,
             ImageUrl1 = request.ImageUrl1,
             ImageUrl2 = request.ImageUrl2,
             ImageUrl3 = request.ImageUrl3,
             Title1 = request.Title1,
             Title2 = request.Title2,
             Title3 = request.Title3,
            };
            await _sliderRepository.CreateAsync(slider);
            var dto = _mapper.Map<CreateSliderDto>(slider);
            return new Response<CreateSliderDto>(true, "Slider created successfully", dto);
        }
    }
}
