using HealthAfterHeartAttack.Models;
using HealthAfterHeartAttack.Persistence;

namespace HealthAfterHeartAttack.Controllers
{
    public class JournalEntryController : ResourceController<JournalEntry>
    {
        public JournalEntryController(JournalEntryService service) : base(service)
        {
        }
    }
}