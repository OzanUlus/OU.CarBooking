using AutoMapper;
using CarBooking.Application.Dtos.AppUserDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser,ResultAppUserDto>().ReverseMap();
        }
    }
}
