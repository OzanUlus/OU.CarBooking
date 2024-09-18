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
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, IResponse<Brand>>
    {
        private readonly IBrandRepository _brandRepository;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IResponse<Brand>> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedBrand = await _brandRepository.GetByIdAsync(request.BrandId);
            if (updatedBrand == null) return new Response<Brand>(false,"Not found",default);

            updatedBrand.BrandName = request.BrandName;
            updatedBrand.BrandImageUrl = request.BrandImageUrl;
            await _brandRepository.UpdateAsync(updatedBrand);
            return new Response<Brand>(true,"Brand is updated",default);

        }
    }
}
