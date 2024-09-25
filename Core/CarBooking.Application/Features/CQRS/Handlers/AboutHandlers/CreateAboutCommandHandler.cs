using AutoMapper;
using CarBooking.Application.Dtos.AboutDtos;
using CarBooking.Application.Features.CQRS.Commands.AboutCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, IResponse<CreateAboutDto>>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public CreateAboutCommandHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<CreateAboutDto>> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var about = new About 
            {
             Title = request.Title,
             Description = request.Description,
             ImageUrl = request.ImageUrl,
            };
            await _aboutRepository.CreateAsync(about);
            var dto = _mapper.Map<CreateAboutDto>(about);
            return new Response<CreateAboutDto>(true,"About is created",dto);
        }
    }
}
