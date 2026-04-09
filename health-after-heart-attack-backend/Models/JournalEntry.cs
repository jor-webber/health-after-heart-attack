using System.ComponentModel.DataAnnotations;

namespace HealthAfterHeartAttack.Models
{
    public class JournalEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}