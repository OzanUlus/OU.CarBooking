using AutoMapper;
using CarBooking.Application.Dtos.SliderDtos;
using CarBooking.Application.Features.CQRS.Queries.SliderQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.SliderHandler
{
    public class GetSliderQueryHandler : IRequestHandler<GetSliderQueryRequest, IResponse<List<ResultSliderDto>>>
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;

        public GetSliderQueryHandler(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultSliderDto>>> Handle(GetSliderQueryRequest request, CancellationToken cancellationToken)
        {
            var slider = await _sliderRepository.GetAllAsync();
            if (slider == null) return new Response<List<ResultSliderDto>>(false, "Slider not found", default);
            var dto = _mapper.Map<List<ResultSliderDto>>(slider);
            return new Response<List<ResultSliderDto>>(true, "succesfully", dto);
        }
    }
}
