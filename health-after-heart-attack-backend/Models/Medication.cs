using System.ComponentModel.DataAnnotations;

namespace HealthAfterHeartAttack.Models
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Dosage { get; set; }

        public string Frequency { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}