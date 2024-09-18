using CarBooking.Application.Features.CQRS.Commands.CarCommand;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Response;
using CarBooking.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommandRequest, IResponse<Car>>
    {
        private readonly ICarRepository _carRepository;

        public DeleteCarCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IResponse<Car>> Handle(DeleteCarCommandRequest request, CancellationToken cancellationToken)
        {
            await _carRepository.DeleteAsync(request.CarId);
            return new Response<Car>(true,"Car is deleted successfully",default);
        }
    }
}
