using AutoMapper;
using CarBooking.Application.Dtos.PaymentDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Mapping
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, ResultPaymentDto>().ReverseMap();
        }
    }
}
