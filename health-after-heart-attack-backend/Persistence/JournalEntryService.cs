using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class JournalEntryService : ResourceService<JournalEntry>
    {
        public JournalEntryService(ApplicationDbContext context) : base(context)
        {
        }
    }
}