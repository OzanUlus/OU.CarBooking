using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CarReviewComponent
{
    public class DeleteCarReviewCommandRequest : IRequest<IResponse<CarReview>>
    {
        public int CarReviewId { get; set; }

        public DeleteCarReviewCommandRequest(int carReviewId)
        {
            CarReviewId = carReviewId;
        }
    }
}
