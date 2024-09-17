using CarBooking.Application.Dtos.CarDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.ImageDtos
{
    public class ResultImageDto
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }

        public ResultCarDto Car { get; set; }
        public int CarId { get; set; }
    }
}
