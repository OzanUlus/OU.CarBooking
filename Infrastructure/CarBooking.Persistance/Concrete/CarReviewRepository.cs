using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;

namespace CarBooking.Persistance.Concrete
{
    public class CarReviewRepository : Repository<CarReview>, ICarReviewRepository
    {
        public CarReviewRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
