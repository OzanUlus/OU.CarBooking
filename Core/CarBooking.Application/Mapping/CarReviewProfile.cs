using AutoMapper;
using CarBooking.Application.Dtos.CarReviewDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class CarReviewProfile : Profile
    {
        public CarReviewProfile()
        {
            CreateMap<CarReview, ResultCarReviewDto>().ReverseMap();
        }

    }
}
