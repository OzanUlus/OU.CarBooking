using AutoMapper;
using CarBooking.Application.Dtos.AboutDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class AboutProfile : Profile
    {
        public AboutProfile()
        {
            CreateMap<About,ResultAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
        }
    }
}
