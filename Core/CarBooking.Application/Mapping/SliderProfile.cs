using AutoMapper;
using CarBooking.Application.Dtos.SliderDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class SliderProfile : Profile
    {
        public SliderProfile()
        {
            CreateMap<Slider,ResultSliderDto>().ReverseMap();
            CreateMap<Slider,CreateSliderDto>().ReverseMap();
        }
    }
}
