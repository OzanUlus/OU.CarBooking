using CarBooking.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string LicensePlate { get; set; }
        public string TransmissionType { get; set; }
        public string FuelType { get; set; }
        public int SeatCount { get; set; }
        public decimal PricePerDay { get; set; }
        public bool AvailabilityStatus { get; set; }


        #region Nav Property
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
        public IEnumerable<CarReview> CarReviews { get; set; }
        #endregion
    }
}
