using CarBooking.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }


        #region Nav Properties
        public Reservation Reservation { get; set; }
        public int ReservationId { get; set; }
        public AppUser AppUser { get; set; }
        public int UserId { get; set; }
        #endregion
    }
}
