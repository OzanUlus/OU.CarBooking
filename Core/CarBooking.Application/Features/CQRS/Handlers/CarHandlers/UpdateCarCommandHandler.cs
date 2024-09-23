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
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommandRequest, IResponse<Car>>
    {
        private readonly ICarRepository _carRepository;

        public UpdateCarCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IResponse<Car>> Handle(UpdateCarCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedCar = await _carRepository.GetByIdAsync(request.CarId);
            if (updatedCar == null) return new Response<Car>(false , "Car not found" ,default);

            updatedCar.PricePerDay = request.PricePerDay;
            updatedCar.LicensePlate = request.LicensePlate;
            updatedCar.AvailabilityStatus = request.AvailabilityStatus;
            updatedCar.BrandId = request.BrandId;
            updatedCar.LocationId = request.LocationId;
            updatedCar.Model = request.Model;
            updatedCar.Year = request.Year;
            updatedCar.TransmissionType = request.TransmissionType;
            updatedCar.FuelType = request.FuelType;
            updatedCar.SeatCount = request.SeatCount;

            await _carRepository.UpdateAsync(updatedCar);

            return new Response<Car>(true, "Car is updated successfully", updatedCar);


        }
    }
}
