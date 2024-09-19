using CarBooking.Application.Dtos.ImageDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.ImageQueries
{
    public class GetAllImagesQueryRequest : IRequest<IResponse<List<ResultImageDto>>>
    {
    }
}
