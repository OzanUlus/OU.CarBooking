using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;

namespace CarBooking.Persistance.Concrete
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
