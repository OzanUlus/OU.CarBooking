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
    public class CreateCarReviewCommandRequest : IRequest<IResponse<CarReview>>
    {
       
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
    }
}
