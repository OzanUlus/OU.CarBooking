using CarBooking.Application.Dtos.CompanyImageDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.CompanyInformationQueries
{
    public class GetAllCompanyInformationsQueryRequest : IRequest<IResponse<List<ResultCompanyInformationDto>>>
    {
    }
}
