using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    public class CareTeamContactController : ResourceController<CareTeamContact>
    {
        public CareTeamContactController(CareTeamContactService service) : base(service)
        {
        }
    }
}