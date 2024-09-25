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
    public class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommandRequest, IResponse<About>>
    {
        private readonly IAboutRepository _aboutRepository;

        public DeleteAboutCommandHandler(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task<IResponse<About>> Handle(DeleteAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _aboutRepository.DeleteAsync(request.AboutId);
            return new Response<About>(true, "About is deleted succesfully", default);
        }
    }
}
