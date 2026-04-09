using System.ComponentModel.DataAnnotations;

namespace HealthAfterHeartAttack.Models
{
    public class CareTeamContact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public string Role { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}