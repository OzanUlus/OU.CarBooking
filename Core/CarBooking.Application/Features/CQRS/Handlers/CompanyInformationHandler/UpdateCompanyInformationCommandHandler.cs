using AutoMapper;
using CarBooking.Application.Dtos.CompanyImageDtos;
using CarBooking.Application.Features.CQRS.Commands.CompanyInformationCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CompanyInformationHandler
{
    public class UpdateCompanyInformationCommandHandler : IRequestHandler<UpdateCompanyInformationCommandRequest, IResponse<UpdateCompanyInformationDto>>
    {
        private readonly ICompanyInformationRepository _companyInformationRepository;
        private readonly IMapper _mapper;

        public UpdateCompanyInformationCommandHandler(ICompanyInformationRepository companyInformationRepository, IMapper mapper)
        {
            _companyInformationRepository = companyInformationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<UpdateCompanyInformationDto>> Handle(UpdateCompanyInformationCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedCI = await _companyInformationRepository.GetByIdAsync(request.CompanyInformationId);
            if (updatedCI == null) return new Response<UpdateCompanyInformationDto>(false, "CI is not found", default);
            
            updatedCI.Title = request.Title;
            updatedCI.Description = request.Description;
            updatedCI.ImageUrl = request.ImageUrl;

            await _companyInformationRepository.UpdateAsync(updatedCI);
            var dto = _mapper.Map<UpdateCompanyInformationDto>(updatedCI);
            return new Response<UpdateCompanyInformationDto>(true,"CI is updated successfully",dto);
        }
    }
}
