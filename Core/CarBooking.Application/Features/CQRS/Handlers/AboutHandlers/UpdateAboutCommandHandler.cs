using AutoMapper;
using CarBooking.Application.Dtos.AboutDtos;
using CarBooking.Application.Features.CQRS.Commands.AboutCommand;
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
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommandRequest, IResponse<UpdateAboutDto>>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public UpdateAboutCommandHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<UpdateAboutDto>> Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedAbout = await _aboutRepository.GetByIdAsync(request.AboutId);
            if (updatedAbout == null) return new Response<UpdateAboutDto>(false,"About is not found",default);

            updatedAbout.Description = request.Description;
            updatedAbout.Title = request.Title;
            updatedAbout.ImageUrl = request.ImageUrl;

            await _aboutRepository.UpdateAsync(updatedAbout);
            var dto = _mapper.Map<UpdateAboutDto>(updatedAbout);
            return new Response<UpdateAboutDto>(true,"About is updated succesfully",dto);
        }
    }
}
