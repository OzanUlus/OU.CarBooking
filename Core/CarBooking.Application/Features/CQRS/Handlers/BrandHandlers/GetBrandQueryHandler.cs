using AutoMapper;
using CarBooking.Application.Dtos.BrandDtos;
using CarBooking.Application.Features.CQRS.Queries.BrandQueries;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQueryRequest, IResponse<ResultBrandDtos>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultBrandDtos>> Handle(GetBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetByIdAsync(request.BrandId);
            var dto = _mapper.Map<ResultBrandDtos>(brand);
            return new Response<ResultBrandDtos>(true, "succesfully", dto); 
        }
    }
}
