using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistance.Concrete
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        private readonly CarBookingContext _context;
        public CarRepository(CarBookingContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetCarByLocationId(int locationId)
        {
            var response = await _context.Cars.Include(c=>c.Location).Where(c =>c.LocationId == locationId).ToListAsync();
            return response;    
        }

        public async Task<List<Car>> GetCarWithInformation()
        {
            var response = await _context.Cars.Include(x => x.Brand).Include(x=>x.Location).ToListAsync();
            return response;
        }
    }
}
