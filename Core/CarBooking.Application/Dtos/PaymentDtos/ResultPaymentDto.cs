using CarBooking.Application.Dtos.ReservationDtos;
using CarBooking.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.PaymentDtos
{
    public class ResultPaymentDto
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        
        public DateTime PaymentDate { get; set; }


        public int UserId { get; set; }
        public ResultReservationDto Reservation { get; set; }
        public int ReservationId { get; set; }

    }
}
