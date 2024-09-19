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
    public class GetAllCarReviewsQueryRequest : IRequest<IResponse<List<ResultCarReviewDto>>>
    {
    }
}
