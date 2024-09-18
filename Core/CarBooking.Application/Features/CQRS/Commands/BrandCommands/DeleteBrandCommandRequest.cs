using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.BrandCommands
{
    public class DeleteBrandCommandRequest : IRequest<IResponse<Brand>>
    {
        public int BrandId { get; set; }

        public DeleteBrandCommandRequest(int brandId)
        {
            BrandId = brandId;
        }
    }
}
