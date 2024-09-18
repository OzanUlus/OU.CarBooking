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
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest, IResponse<Brand>>
    {
        private readonly IBrandRepository _brandRepository;

        public DeleteBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IResponse<Brand>> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _brandRepository.DeleteAsync(request.BrandId);
            return new Response<Brand>(true,"Brand is deleted succesfully",default);
        }
    }
}
