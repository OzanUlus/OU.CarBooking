using CarBooking.Application.Dtos.SliderDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.SliderQueries
{
    public class GetSliderQueryRequest : IRequest<IResponse<List<ResultSliderDto>>>
    {
    }
}
