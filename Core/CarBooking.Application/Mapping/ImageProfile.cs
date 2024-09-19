using AutoMapper;
using CarBooking.Application.Dtos.ImageDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<Image, ResultImageDto>().ReverseMap() ;
        }
    }
}
