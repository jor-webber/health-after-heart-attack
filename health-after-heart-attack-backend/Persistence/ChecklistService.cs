using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class ChecklistService : ResourceService<Checklist>
    {
        public ChecklistService(ApplicationDbContext context) : base(context)
        {
        }
    }
}