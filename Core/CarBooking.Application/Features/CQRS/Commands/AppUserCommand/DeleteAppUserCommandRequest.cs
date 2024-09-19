using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.AppUserCommand
{
    public class DeleteAppUserCommandRequest : IRequest<IdentityResult>
    {
        public int UserId { get; set; }

        public DeleteAppUserCommandRequest(int userId)
        {
            UserId = userId;
        }
    }
}
