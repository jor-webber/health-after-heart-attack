using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class CarePlanService : ResourceService<CarePlan>
    {
        public CarePlanService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<CarePlan>> GetAllAsync()
        {
            return await _context.CarePlans.ToListAsync();
        }

        public async Task<CarePlan?> GetByIdAsync(int id)
        {
            return await _context.CarePlans.FindAsync(id);
        }

        public async Task AddAsync(CarePlan carePlan)
        {
            _context.CarePlans.Add(carePlan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CarePlan carePlan)
        {
            _context.Entry(carePlan).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var carePlan = await _context.CarePlans.FindAsync(id);
            if (carePlan != null)
            {
                _context.CarePlans.Remove(carePlan);
                await _context.SaveChangesAsync();
            }
        }
    }
}