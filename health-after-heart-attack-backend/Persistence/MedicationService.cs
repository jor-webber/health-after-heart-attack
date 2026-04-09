using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class MedicationService : ResourceService<Medication>
    {
        public MedicationService(ApplicationDbContext context) : base(context)
        {
        }
    }
}