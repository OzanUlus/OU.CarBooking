using AutoMapper;
using CarBooking.Application.Dtos.AppUserDtos;
using CarBooking.Application.Features.CQRS.Queries.AppUserQueries;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.AppUserHandlers
{
    public class GetAppUserQueryHandler : IRequestHandler<GetAppUserQueryRequest, IResponse<ResultAppUserDto>>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public GetAppUserQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IResponse<ResultAppUserDto>> Handle(GetAppUserQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            var userDto = _mapper.Map<ResultAppUserDto>(user);
            return new Response<ResultAppUserDto>(true,"User is listed successfully",userDto);
        }
    }
}
