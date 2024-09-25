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
    public class GetAboutQueyHandler : IRequestHandler<GetAboutQueryRequest, IResponse<ResultAboutDto>>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public GetAboutQueyHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultAboutDto>> Handle(GetAboutQueryRequest request, CancellationToken cancellationToken)
        {
            var about = await _aboutRepository.GetByIdAsync(request.AboutId);
            if (about == null) return new Response<ResultAboutDto>(false,"About not found",default);
            var dto = _mapper.Map<ResultAboutDto>(about);
            return new Response<ResultAboutDto>(true, "succesfully", dto);
        }
    }
}
