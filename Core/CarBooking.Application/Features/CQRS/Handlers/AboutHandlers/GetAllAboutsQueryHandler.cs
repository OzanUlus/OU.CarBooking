using AutoMapper;
using CarBooking.Application.Dtos.AboutDtos;
using CarBooking.Application.Features.CQRS.Queries.AboutQuery;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAllAboutsQueryHandler : IRequestHandler<GetAllAboutsQueryRequest, IResponse<List<ResultAboutDto>>>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public GetAllAboutsQueryHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultAboutDto>>> Handle(GetAllAboutsQueryRequest request, CancellationToken cancellationToken)
        {
            var abouts = await _aboutRepository.GetAllAsync();
            if (abouts == null) return new Response<List<ResultAboutDto>>(false,"There is no abouts",default);
            var dto = _mapper.Map<List<ResultAboutDto>>(abouts);
            return new Response<List<ResultAboutDto>>(true,"Abouts are listed successfully",dto);
        }
    }
}
