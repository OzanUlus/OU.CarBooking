using AutoMapper;
using CarBooking.Application.Dtos.BrandDtos;
using CarBooking.Application.Features.CQRS.Commands.BrandCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, IResponse<Brand>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<Brand>> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var brand = new Brand {
                BrandName = request.BrandName,
                BrandImageUrl = request.BrandImageUrl,
            };
            await _brandRepository.CreateAsync(brand);


            return new Response<Brand>(true,"Brand is created successfully",brand);
        }
    }
}
