using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;

namespace CarBooking.Persistance.Concrete
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
