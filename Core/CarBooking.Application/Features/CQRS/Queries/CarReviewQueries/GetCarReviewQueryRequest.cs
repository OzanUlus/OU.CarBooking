using CarBooking.Application.Dtos.CarReviewDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.CarReviewQueries
{
    public class GetCarReviewQueryRequest : IRequest<IResponse<ResultCarReviewDto>>
    {
        public int CarReviewIc { get; set; }

        public GetCarReviewQueryRequest(int carReviewIc)
        {
            CarReviewIc = carReviewIc;
        }
    }
}
