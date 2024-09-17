using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Application.Dtos.PaymentDtos;
using CarBooking.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.ReservationDtos
{
    public class ResultReservationDto
    {
        public int ReservationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }


        public ResultCarDto Car { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public ResultPaymentDto Payment { get; set; }
    }
}
