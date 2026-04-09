using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class EducationalResourceService : ResourceService<EducationalResource>
    {
        public EducationalResourceService(ApplicationDbContext context) : base(context)
        {
        }
    }
}