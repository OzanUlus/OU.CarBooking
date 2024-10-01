using AutoMapper;
using CarBooking.Application.Dtos.CompanyImageDtos;
using CarBooking.Application.Features.CQRS.Queries.CompanyInformationQueries;
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
    public class GetAllCompanyInformationQueryHandler : IRequestHandler<GetAllCompanyInformationsQueryRequest, IResponse<List<ResultCompanyInformationDto>>>
    {
        private readonly ICompanyInformationRepository _companyInformationRepository;
        private readonly IMapper _mapper;

        public GetAllCompanyInformationQueryHandler(ICompanyInformationRepository companyInformationRepository, IMapper mapper)
        {
            _companyInformationRepository = companyInformationRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ResultCompanyInformationDto>>> Handle(GetAllCompanyInformationsQueryRequest request, CancellationToken cancellationToken)
        {
            var CI = await _companyInformationRepository.GetAllAsync();
            if (CI == null) return new Response<List<ResultCompanyInformationDto>>(false,"CI is not listed",default); 

            var dto = _mapper.Map<List<ResultCompanyInformationDto>>(CI);
            return new Response<List<ResultCompanyInformationDto>>(true,"successfully",dto);
        }
    }
}
