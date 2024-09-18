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
    public class CreateCarCommandHandlers : IRequestHandler<CreateCarCommandRequest, IResponse<Car>>
    {
        private readonly ICarRepository _carRepository;

        public CreateCarCommandHandlers(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IResponse<Car>> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
        {
            await _carRepository.CreateAsync(new Car
            {
                Model = request.Model,
                AvailabilityStatus = request.AvailabilityStatus,
                FuelType  = request.FuelType,
                LicensePlate = request.LicensePlate,
                PricePerDay = request.PricePerDay,
                SeatCount = request.SeatCount,
                TransmissionType = request.TransmissionType,
                Yaer = request.Yaer,
                BrandId = request.BrandId,
                LocationId = request.LocationId,
                
            });
            return new Response<Car>(true,"Car is created Successfully",default);
        }
    }
} 
