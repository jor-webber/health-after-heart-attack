using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    public class AppointmentController : ResourceController<Appointment>
    {
        public AppointmentController(AppointmentService service) : base(service)
        {
        }
    }
}