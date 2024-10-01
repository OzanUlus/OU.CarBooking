using CarBooking.Application.Features.CQRS.Commands.CompanyInformationCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CompanyInformationHandler
{
    public class DeleteCompanyInformationCommandHandler : IRequestHandler<DeleteCompanyInformationCommandRequest, IResponse<CompanyInformation>>
    {
        private readonly ICompanyInformationRepository _companyInformationRepository;

        public DeleteCompanyInformationCommandHandler(ICompanyInformationRepository companyInformationRepository)
        {
            _companyInformationRepository = companyInformationRepository;
        }

        public async Task<IResponse<CompanyInformation>> Handle(DeleteCompanyInformationCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyInformationRepository.DeleteAsync(request.CompanyınformationId);
            return new Response<CompanyInformation>(true, "CI is deleted Successfully", default);
        }
    }
}
