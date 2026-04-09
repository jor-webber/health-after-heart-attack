using System.ComponentModel.DataAnnotations;

namespace HealthAfterHeartAttack.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(200)]
        public string Location { get; set; }

        public string Notes { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}