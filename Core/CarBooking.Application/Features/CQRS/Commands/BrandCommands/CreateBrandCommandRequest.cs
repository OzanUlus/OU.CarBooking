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
    public class CreateBrandCommandRequest : IRequest<IResponse<Brand>>
    {
        public string BrandName { get; set; }
        public string BrandImageUrl { get; set; }
    }
}
