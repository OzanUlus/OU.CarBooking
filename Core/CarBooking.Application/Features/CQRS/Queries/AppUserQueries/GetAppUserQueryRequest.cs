using CarBooking.Application.Dtos.AppUserDtos;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.AppUserQueries
{
    public class GetAppUserQueryRequest : IRequest<IResponse<ResultAppUserDto>>
    {
        public int UserId { get; set; }

        public GetAppUserQueryRequest(int userId)
        {
            UserId = userId;
        }
    }
}
