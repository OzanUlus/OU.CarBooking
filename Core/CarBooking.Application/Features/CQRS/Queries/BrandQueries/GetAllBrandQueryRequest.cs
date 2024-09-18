using CarBooking.Application.Dtos.BrandDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetAllBrandQueryRequest : IRequest<IResponse<List<ResultBrandDtos>>>
    {
    }
}
