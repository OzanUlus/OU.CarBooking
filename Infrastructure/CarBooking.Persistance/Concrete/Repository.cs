using CarBooking.Application.Interfaces;
using CarBooking.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistance.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarBookingContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(CarBookingContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _dbSet.ToListAsync();
            return entities;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity!;
        }

        public async Task UpdateAsync(T entity)
        {
           _dbSet.Update(entity);
            await _context.SaveChangesAsync();  
        }
    }
}
