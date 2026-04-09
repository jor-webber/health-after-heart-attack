using Microsoft.AspNetCore.Mvc;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ResourceController<T> : ControllerBase where T : class
    {
        private readonly ResourceService<T> _service;

        protected ResourceController(ResourceService<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _service.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.GetType().GetProperty("Id")?.GetValue(entity) }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entityId = entity.GetType().GetProperty("Id")?.GetValue(entity);
            if (entityId == null || !entityId.Equals(id))
            {
                return BadRequest("Entity ID mismatch.");
            }

            await _service.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}