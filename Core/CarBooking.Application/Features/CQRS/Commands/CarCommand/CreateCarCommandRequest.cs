using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CarCommand
{
    public class CreateCarCommandRequest : IRequest<IResponse<Car>>
    {
       
        public string Model { get; set; }
        public string Yaer { get; set; }
        public string LicensePlate { get; set; }
        public string TransmissionType { get; set; }
        public string FuelType { get; set; }
        public int SeatCount { get; set; }
        public decimal PricePerDay { get; set; }
        public bool AvailabilityStatus { get; set; }
        public int BrandId { get; set; }
        public int LocationId { get; set; }
    }
}
