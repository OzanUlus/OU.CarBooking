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

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IResponse<Brand>> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _brandRepository.CreateAsync(new Brand 
            {
             BrandName = request.BrandName,
             BrandImageUrl = request.BrandImageUrl,
            });
            return new Response<Brand>(true,"Brand is created successfully",default);
        }
    }
}
