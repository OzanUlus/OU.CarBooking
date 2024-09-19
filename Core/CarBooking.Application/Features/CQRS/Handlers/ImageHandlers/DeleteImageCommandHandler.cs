using CarBooking.Application.Features.CQRS.Commands.ImageCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.ImageHandlers
{
    public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommandRequest, IResponse<Image>>
    {
        private readonly IImageRepository _imageRepository;

        public DeleteImageCommandHandler(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<IResponse<Image>> Handle(DeleteImageCommandRequest request, CancellationToken cancellationToken)
        {
            await _imageRepository.DeleteAsync(request.ImageId);
            return new Response<Image>(true,"Image is deleted successfully",default);
        }
    }
}
