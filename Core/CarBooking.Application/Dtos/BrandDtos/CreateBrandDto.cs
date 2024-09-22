using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.BrandDtos
{
   public class CreateBrandDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int BrandImageUrl { get; set; }
    }
}
