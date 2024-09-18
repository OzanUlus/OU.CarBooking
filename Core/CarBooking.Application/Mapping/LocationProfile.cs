using AutoMapper;
using CarBooking.Application.Dtos.LocationDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
           CreateMap<Location , ResultLocationDto>().ReverseMap();
        }
    }
}
