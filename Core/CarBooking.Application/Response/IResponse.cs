using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Response
{
    public interface IResponse<T>
    {
        bool Success { get; set; }
        string Message { get; set; }
        T Data { get; set; }
    }
}
