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
    public class CreateCarReviewCommandHandler : IRequestHandler<CreateCarReviewCommandRequest, IResponse<CarReview>>
    {
        private readonly ICarReviewRepository _carReviewRepository;

        public CreateCarReviewCommandHandler(ICarReviewRepository carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }

        public async Task<IResponse<CarReview>> Handle(CreateCarReviewCommandRequest request, CancellationToken cancellationToken)
        {
            await _carReviewRepository.CreateAsync(new CarReview 
            {
             Comment = request.Comment,
             CarId = request.CarId,
             CreatedDate = DateTime.UtcNow,
             Rating = request.Rating,
             UserId = request.UserId,
            });
            return new Response<CarReview>(true,"Car review is created successfully",default);
        }
    }
}
