using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    public class EducationalResourceController : ResourceController<EducationalResource>
    {
        public EducationalResourceController(EducationalResourceService service) : base(service)
        {
        }
    }
}