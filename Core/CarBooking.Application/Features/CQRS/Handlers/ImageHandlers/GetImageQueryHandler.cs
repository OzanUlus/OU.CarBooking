using AutoMapper;
using CarBooking.Application.Dtos.ImageDtos;
using CarBooking.Application.Features.CQRS.Queries.ImageQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.ImageHandlers
{
    public class GetImageQueryHandler : IRequestHandler<GetImageQueryRequest, IResponse<ResultImageDto>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetImageQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultImageDto>> Handle(GetImageQueryRequest request, CancellationToken cancellationToken)
        {
            var image = await _imageRepository.GetByIdAsync(request.ImageId);
            if (image == null) return new Response<ResultImageDto>(false,"Image is not not found",default);
            var imageDto = _mapper.Map<ResultImageDto>(image);
            return new Response<ResultImageDto>(true,"Image is listed Successfully",imageDto);
        }
    }
}
