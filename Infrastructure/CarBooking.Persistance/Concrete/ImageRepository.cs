using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;

namespace CarBooking.Persistance.Concrete
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
