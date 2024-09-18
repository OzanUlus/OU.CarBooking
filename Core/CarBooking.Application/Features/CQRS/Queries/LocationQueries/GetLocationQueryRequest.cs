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
    public class GetLocationQueryRequest : IRequest<IResponse<ResultLocationDto>>
    {
        public int LocationId { get; set; }

        public GetLocationQueryRequest(int locationId)
        {
            LocationId = locationId;
        }
    }
}
