using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.CarDtos
{
    public class GetCarWithInformationDto
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
        public string BrandName { get; set; }
        public string LocationName { get; set; }

    }
}
