using System.ComponentModel.DataAnnotations;

namespace HealthAfterHeartAttack.Models
{
    public class Checklist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}