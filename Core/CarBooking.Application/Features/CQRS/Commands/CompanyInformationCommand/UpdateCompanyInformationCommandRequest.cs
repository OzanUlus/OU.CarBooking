using CarBooking.Application.Dtos.CompanyImageDtos;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CompanyInformationCommand
{
    public class UpdateCompanyInformationCommandRequest : IRequest<IResponse<UpdateCompanyInformationDto>>
    {
        public int CompanyInformationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
