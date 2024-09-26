using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistance.Concrete
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        private readonly CarBookingContext _context;
        public ImageRepository(CarBookingContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Image>> GetAllImageWithCars()
        {
            var response = await _context.Images.Include(i=>i.Car).ToListAsync();
            return response;
        }
    }
}
