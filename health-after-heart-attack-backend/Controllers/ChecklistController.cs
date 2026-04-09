using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    public class ChecklistController : ResourceController<Checklist>
    {
        public ChecklistController(ChecklistService service) : base(service)
        {
        }
    }
}