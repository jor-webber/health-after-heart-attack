using HealthAfterHeartAttack.Models;
using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttackBackend.Data;

namespace HealthAfterHeartAttack.Persistence
{
    public class AppointmentService : ResourceService<Appointment>
    {
        public AppointmentService(ApplicationDbContext context) : base(context)
        {
        }
    }
}