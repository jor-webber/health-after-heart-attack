using Microsoft.AspNetCore.Mvc;
using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarePlanController : ResourceController<CarePlan>
    {
        public CarePlanController(CarePlanService service) : base(service)
        {
        }

        [HttpGet]
        public IActionResult GetAllCarePlans()
        {
            return Ok(GetAll());
        }
    }
}