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
    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommandRequest, IResponse<Image>>
    {
        private readonly IImageRepository _imageRepository;

        public CreateImageCommandHandler(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<IResponse<Image>> Handle(CreateImageCommandRequest request, CancellationToken cancellationToken)
        {
            var image = new Image
            {
                CarId = request.CarId,
                ImageUrl = request.ImageUrl,
            };
            await _imageRepository.CreateAsync(image);
            
            return new Response<Image>(true,"Image is created successfully",image);
        }
    }
}
