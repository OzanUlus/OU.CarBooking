using CarBooking.Application.Dtos.BrandDtos;
using CarBooking.Application.Dtos.CarReviewDtos;
using CarBooking.Application.Dtos.ImageDtos;
using CarBooking.Application.Dtos.LocationDtos;
using CarBooking.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.CarDtos
{
    public class ResultCarDto
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Yaer { get; set; }
        public string LicensePlate { get; set; }
        public string TransmissionType { get; set; }
        public string FuelType { get; set; }
        public int SeatCount { get; set; }
        public decimal PricePerDay { get; set; }
        public bool AvailabilityStatus { get; set; }

        public ResultBrandDtos Brand { get; set; }
        public int BrandId { get; set; }
        public ResultLocationDto Location { get; set; }
        public int LocationId { get; set; }
        IEnumerable<ResultCarReviewDto> CarReviews { get; set; }
        
        public List<string> Images { get; set; }
    }
}
