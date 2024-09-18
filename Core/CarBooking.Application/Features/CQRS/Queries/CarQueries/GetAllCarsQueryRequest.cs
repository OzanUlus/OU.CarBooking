using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.CarQueries
{
    public class GetAllCarsQueryRequest : IRequest<IResponse<List<ResultCarDto>>>
    {
    }
}
