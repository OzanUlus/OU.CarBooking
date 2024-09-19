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
    public class GetAllImagesQueryHandler : IRequestHandler<GetAllImagesQueryRequest, IResponse<List<ResultImageDto>>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetAllImagesQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultImageDto>>> Handle(GetAllImagesQueryRequest request, CancellationToken cancellationToken)
        {
            var images = await _imageRepository.GetAllAsync();
            if (images == null) return new Response<List<ResultImageDto>>(false,"Images are not found",default);
            var imagesDto = _mapper.Map<List<ResultImageDto>>(images);
            return new Response<List<ResultImageDto>>(true,"Images are listed successfully",imagesDto);
        }
    }
}
