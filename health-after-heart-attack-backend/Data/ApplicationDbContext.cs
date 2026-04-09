using Microsoft.EntityFrameworkCore;
using HealthAfterHeartAttack.Models;

namespace HealthAfterHeartAttackBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define DbSets for your entities here
        public DbSet<User> Users { get; set; }
        public DbSet<CarePlan> CarePlans { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<EducationalResource> EducationalResources { get; set; }
        public DbSet<CareTeamContact> CareTeamContacts { get; set; }
    }
}