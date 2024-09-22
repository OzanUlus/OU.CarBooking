using AutoMapper;
using CarBooking.Application.Dtos.BrandDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand,ResultBrandDtos>().ReverseMap();
            CreateMap<Brand,CreateBrandDto>().ReverseMap();

           
        }
    }
}
