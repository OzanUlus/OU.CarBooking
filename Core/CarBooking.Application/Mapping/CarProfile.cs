using AutoMapper;
using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car,ResultCarDto>().ReverseMap();
        }
    }
}
