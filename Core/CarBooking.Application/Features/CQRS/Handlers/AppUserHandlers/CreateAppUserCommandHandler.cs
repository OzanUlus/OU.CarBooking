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
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommandRequest, IdentityResult>
    {
        private readonly UserManager<AppUser> _userManager;

        public CreateAppUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(CreateAppUserCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _userManager.CreateAsync(new AppUser
            {
                Address = request.Address,
                Email = request.Email,
                LastName = request.LastName,
                Name = request.Name,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,

            },request.Password);
            return result;
        }
    }
}
