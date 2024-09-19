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
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommandRequest, IdentityResult>
    {
        private readonly UserManager<AppUser> _userManager;

        public UpdateAppUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(UpdateAppUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user != null)
            {
                user.Address = request.Address;
                user.PhoneNumber = request.PhoneNumber ;
                user.LastName = request.LastName;
                user.UserName = request.UserName ;
                user.Email =request.Email;
                user.Name =request.Name ;

                var result = await _userManager.UpdateAsync(user);
                return result;

            }
            return IdentityResult.Failed(new IdentityError { Description="User not found"});
        }
    }
}
