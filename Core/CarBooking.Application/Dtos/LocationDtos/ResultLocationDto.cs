using CarBooking.Application.Dtos.CarDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.LocationDtos
{
    public class ResultLocationDto
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        IEnumerable<ResultCarDto> Cars { get; set; }
    }
}
