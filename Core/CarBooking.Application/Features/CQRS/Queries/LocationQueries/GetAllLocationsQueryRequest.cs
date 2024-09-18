using CarBooking.Application.Dtos.LocationDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.LocationQueries
{
    public class GetAllLocationsQueryRequest : IRequest<IResponse<List<ResultLocationDto>>>
    {
    }
}
