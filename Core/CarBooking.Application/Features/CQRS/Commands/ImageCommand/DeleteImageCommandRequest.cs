using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.ImageCommand
{
    public class DeleteImageCommandRequest : IRequest<IResponse<Image>>
    {
        public int ImageId { get; set; }

        public DeleteImageCommandRequest(int ımageId)
        {
            ImageId = ımageId;
        }
    }
}
