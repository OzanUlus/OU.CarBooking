using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Dtos.AppUserDtos
{
    public class LoginDto
    {
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
