using Microsoft.AspNetCore.Mvc;
using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationController : ResourceController<Medication>
    {
        public MedicationController(MedicationService service) : base(service)
        {
        }

        [HttpGet]
        public IActionResult GetAllMedications()
        {
            return Ok(base.GetAll());
        }
    }
}