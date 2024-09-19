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
    public class DeleteAppUserCommandHandler : IRequestHandler<DeleteAppUserCommandRequest,IdentityResult>
    {
        private readonly UserManager<AppUser> _userManager;

        public DeleteAppUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(DeleteAppUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null) return IdentityResult.Failed(new IdentityError { Description ="User not found"});
            var result = await _userManager.DeleteAsync(user);
            return result;
        }
    }
}
