using AutoMapper;
using CarBooking.Application.Dtos.CompanyImageDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class CompanyInformationProfile : Profile
    {
        public CompanyInformationProfile()
        {
            CreateMap<CompanyInformation,ResultCompanyInformationDto>().ReverseMap();
            CreateMap<CompanyInformation,CreateCompanyInformationDto>().ReverseMap();
            CreateMap<CompanyInformation,UpdateCompanyInformationDto>().ReverseMap();
        }
    }
}
