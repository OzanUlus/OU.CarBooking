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
    public class GetAllAppUsersQueryHandler : IRequestHandler<GetAllAppUsersQueryRequest, IResponse<List<ResultAppUserDto>>>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public GetAllAppUsersQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultAppUserDto>>> Handle(GetAllAppUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var users = _userManager.Users.ToList();
            var usersDto = _mapper.Map<List<ResultAppUserDto>>(users);
            return new Response<List<ResultAppUserDto>>(true,"Users are listed successfully",usersDto);
        }
    }
}
