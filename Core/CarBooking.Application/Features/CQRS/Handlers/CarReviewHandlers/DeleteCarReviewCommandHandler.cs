using CarBooking.Application.Features.CQRS.Commands.CarReviewComponent;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarReviewHandlers
{
    public class DeleteCarReviewCommandHandler : IRequestHandler<DeleteCarReviewCommandRequest, IResponse<CarReview>>
    {
        private readonly ICarReviewRepository _carReviewRepository;

        public DeleteCarReviewCommandHandler(ICarReviewRepository carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task<IResponse<CarReview>> Handle(DeleteCarReviewCommandRequest request, CancellationToken cancellationToken)
        {
            await _carReviewRepository.DeleteAsync(request.CarReviewId);
            return new Response<CarReview>(true,"Car review is deleted successfully",default);
        }
    }
}
