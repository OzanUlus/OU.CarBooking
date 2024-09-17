using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;

namespace CarBooking.Persistance.Concrete
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
