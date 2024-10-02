using CarBooking.Application.Dtos.AppUserDtos;
using CarBooking.Application.Features.CQRS.Commands.AppUserCommand;
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
    public class LoginCommandRequestHandler : IRequestHandler<LoginCommandRequest, LoginDto>
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandRequestHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<LoginDto> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null) return new LoginDto { Message = "Email or password wrong"};

            var result = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!result) return new LoginDto { Message = "Email or password wrong" };

            return new LoginDto { Message = "Login Successful", Token = "" };
        }
    }
}
