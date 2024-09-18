using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CarCommand
{
    public class DeleteCarCommandRequest : IRequest<IResponse<Car>>
    {
        public int CarId { get; set; }

        public DeleteCarCommandRequest(int carId)
        {
            CarId = carId;
        }
    }
}
