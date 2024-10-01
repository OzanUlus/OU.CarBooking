using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CompanyInformationCommand
{
    public class DeleteCompanyInformationCommandRequest : IRequest<IResponse<CompanyInformation>>
    {
        public int CompanyınformationId { get; set; }

        public DeleteCompanyInformationCommandRequest(int companyınformationId)
        {
            CompanyınformationId = companyınformationId;
        }
    }
}
