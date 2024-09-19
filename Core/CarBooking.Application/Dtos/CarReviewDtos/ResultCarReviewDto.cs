using CarBooking.Application.Dtos.CarDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.CarReviewDtos
{
    public class ResultCarReviewDto
    {
        public int CarReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public int UserId { get; set; }
        public ResultCarDto Car { get; set; }

        public int CarId { get; set; }

    }
}
