using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Response
{
    public class Response<T> : IResponse<T>
    {
        public bool Success { get ; set ; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Response(bool success, string message, T data )
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public static Response<T> SuccessResponse(T data, string message) 
        {
            return new Response<T>(true,message,data);
        }

        public static Response<T> ErrorResponse(string message) 
        {
            return new Response<T>(false,message,default);
        }

       
    }
}
