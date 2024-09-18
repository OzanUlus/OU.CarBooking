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
    public class GetaAllBrandQueryHandler : IRequestHandler<GetAllBrandQueryRequest, IResponse<List<ResultBrandDtos>>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetaAllBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultBrandDtos>>> Handle(GetAllBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetAllAsync();
            var dto = _mapper.Map<List<ResultBrandDtos>>(brands);
            return new Response<List<ResultBrandDtos>>(true,"Brand is listed successfully",dto);
        }
    }
}
