using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class CareTeamContactService : ResourceService<CareTeamContact>
    {
        public CareTeamContactService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<CareTeamContact>> GetAllAsync()
        {
            return await _context.CareTeamContacts.ToListAsync();
        }

        public async Task<CareTeamContact?> GetByIdAsync(int id)
        {
            return await _context.CareTeamContacts.FindAsync(id);
        }

        public async Task AddAsync(CareTeamContact careTeamContact)
        {
            _context.CareTeamContacts.Add(careTeamContact);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CareTeamContact careTeamContact)
        {
            _context.Entry(careTeamContact).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var careTeamContact = await _context.CareTeamContacts.FindAsync(id);
            if (careTeamContact != null)
            {
                _context.CareTeamContacts.Remove(careTeamContact);
                await _context.SaveChangesAsync();
            }
        }
    }
}