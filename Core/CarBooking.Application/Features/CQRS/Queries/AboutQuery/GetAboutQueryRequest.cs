using CarBooking.Application.Dtos.AboutDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.AboutQuery
{
    public class GetAboutQueryRequest : IRequest<IResponse<ResultAboutDto>>
    {
        public int AboutId { get; set; }

        public GetAboutQueryRequest(int aboutId)
        {
            AboutId = aboutId;
        }
    }
}
