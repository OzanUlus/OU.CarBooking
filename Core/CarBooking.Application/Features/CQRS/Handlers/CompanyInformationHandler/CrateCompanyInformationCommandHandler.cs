using AutoMapper;
using CarBooking.Application.Dtos.CompanyImageDtos;
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
    public class CrateCompanyInformationCommandHandler : IRequestHandler<CreateCompanyInformationCommandRequest, IResponse<CreateCompanyInformationDto>>
    {
        private readonly ICompanyInformationRepository _companyInformationRepository;
        private readonly IMapper _mapper;


        public CrateCompanyInformationCommandHandler(ICompanyInformationRepository companyInformationRepository, IMapper mapper)
        {
            _companyInformationRepository = companyInformationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<CreateCompanyInformationDto>> Handle(CreateCompanyInformationCommandRequest request, CancellationToken cancellationToken)
        {
           var companyInformation = new CompanyInformation 
           {
             Title = request.Title,
             Description = request.Description,
             ImageUrl = request.ImageUrl,
           };
            await _companyInformationRepository.CreateAsync(companyInformation);
            var dto = _mapper.Map<CreateCompanyInformationDto>(companyInformation);

            return new Response<CreateCompanyInformationDto>(true,"CI is created successfully", dto);
        }
    }
}
