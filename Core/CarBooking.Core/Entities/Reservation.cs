using CarBooking.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }


        #region Nav Properties
        public Car Car { get; set; }
        public int CarId { get; set; }
        public AppUser AppUser { get; set; }
        public int UserId { get; set; }
        public Payment Payment { get; set; }
        #endregion

    }
}
