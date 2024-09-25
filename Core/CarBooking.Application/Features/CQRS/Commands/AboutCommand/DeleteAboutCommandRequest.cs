using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.AboutCommand
{
    public class DeleteAboutCommandRequest : IRequest<IResponse<About>>
    {
        public int AboutId { get; set; }

        public DeleteAboutCommandRequest(int aboutId)
        {
            AboutId = aboutId;
        }
    }
}
